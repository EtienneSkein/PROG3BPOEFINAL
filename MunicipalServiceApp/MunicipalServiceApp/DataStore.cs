using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static MunicipalServiceApp.DataStore;

namespace MunicipalServiceApp
{
    // Class to store the search history of users
    public class UserSearchHistory
    {
        public AVLTree<DateTime> SearchedDates { get; set; } = new AVLTree<DateTime>();
        public AVLTree<int> SearchedCategories { get; set; } = new AVLTree<int>();
    }

        public class DataStore
        {
            public UserSearchHistory SearchHistory { get; set; } = new UserSearchHistory();

            private PriorityQueue<Issue, int> issuePriorityQueue = new PriorityQueue<Issue, int>();
            private AVLTree<int> issueTree = new AVLTree<int>();
            private List<Event> eventList = new List<Event>(); // List to manage events
            private Graph serviceRequestGraph = new Graph();
            private int issueIdCounter = 1;
            private int eventIdCounter = 1;

            // Add search criteria to the user's search history
            public void AddToSearchHistory(DateTime? date, int category)
            {
                try
                {
                    if (date.HasValue)
                        SearchHistory.SearchedDates.Insert(date.Value);

                    if (category != -1)
                        SearchHistory.SearchedCategories.Insert(category);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding to search history: {ex.Message}", "Search History Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Add a new issue to the datastore
            public void AddIssue(Issue issue)
            {
                try
                {
                    issue.Id = issueIdCounter++;
                    issueTree.Insert(issue.Id);
                    issuePriorityQueue.Enqueue(issue, issue.Priority);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding issue: {ex.Message}", "Issue Addition Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Add a new event to the datastore
            public void AddEvent(Event newEvent)
            {
                try
                {
                    newEvent.Id = eventIdCounter++;
                    eventList.Add(newEvent); // Add the event to the event list
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding event: {ex.Message}", "Event Addition Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Get all events from the datastore
            public List<Event> GetAllEvents()
            {
                try
                {
                    return eventList.ToList(); // Return a copy of the event list
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error retrieving all events: {ex.Message}", "Retrieve Events Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<Event>();
                }
            }

            // Get an issue by its ID
            public Issue GetIssueById(int id)
            {
                if (issueTree.Contains(id))
                    return issuePriorityQueue.UnorderedItems.First(i => i.Element.Id == id).Element;

                return null;
            }

            // Retrieve all issues in priority order
            public ICollection<Issue> GetAllIssues()
            {
                try
                {
                    return issuePriorityQueue.UnorderedItems.Select(i => i.Element).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error retrieving all issues: {ex.Message}", "Retrieve Issues Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<Issue>();
                }
            }

            // Search for events based on date and category
            public List<Issue> SearchEvents(DateTime? date, int category)
            {
                var results = new List<Issue>();

                try
                {
                    foreach (var issue in issuePriorityQueue.UnorderedItems.Select(i => i.Element))
                    {
                        bool matchesDate = !date.HasValue || issue.DateReported.Date == date.Value.Date;
                        bool matchesCategory = category == -1 || issue.Priority == category;

                        if (matchesDate && matchesCategory)
                            results.Add(issue);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error searching for events: {ex.Message}", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return results;
            }

            // Add dependency between issues
            public void AddIssueDependency(int issueId, int dependentIssueId)
            {
                serviceRequestGraph.AddNode(issueId);
                serviceRequestGraph.AddNode(dependentIssueId);
                serviceRequestGraph.AddEdge(issueId, dependentIssueId);
            }

            // Resolve dependencies for a specific issue
            public List<int> ResolveDependencies(int issueId)
            {
                var resolved = new List<int>();
                var visited = new HashSet<int>();

                void DFS(int current)
                {
                    if (!visited.Contains(current))
                    {
                        visited.Add(current);
                        foreach (var neighbor in serviceRequestGraph.GetNeighbors(current))
                        {
                            DFS(neighbor);
                        }
                        resolved.Add(current);
                    }
                }

                DFS(issueId);
                return resolved;
            }

            // Recommend events based on user's search history
            public List<Issue> RecommendEventsBasedOnHistory()
            {
                var recommendedEvents = new List<Issue>();

                try
                {
                    if (!SearchHistory.SearchedDates.InOrderTraversal().Any() && !SearchHistory.SearchedCategories.InOrderTraversal().Any())
                    {
                        MessageBox.Show("No search history available to recommend events.", "No Recommendations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return recommendedEvents;
                    }

                    foreach (var issue in issuePriorityQueue.UnorderedItems.Select(i => i.Element))
                    {
                        bool similarDate = SearchHistory.SearchedDates.InOrderTraversal().Any(date => Math.Abs((issue.DateReported - date).Days) <= 7);
                        bool similarCategory = SearchHistory.SearchedCategories.Contains(issue.Priority);

                        if (similarDate || similarCategory)
                            recommendedEvents.Add(issue);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error recommending events: {ex.Message}", "Recommendation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return recommendedEvents;
            }

            // Find minimum spanning tree (MST) for service request dependencies
            public List<Edge> FindServiceRequestMST()
            {
                try
                {
                    var edges = serviceRequestGraph.GetAllEdges();
                    var mst = new MST();
                    return mst.FindMST(edges, serviceRequestGraph.NodeCount);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error finding MST: {ex.Message}", "MST Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<Edge>();
                }
            }

            // Edge class for MST
            public class Edge
            {
                public int From { get; set; }
                public int To { get; set; }
                public int Weight { get; set; } // Weight represents cost or distance
            }

            // MST class for finding the Minimum Spanning Tree
            public class MST
            {
                public List<Edge> FindMST(List<Edge> edges, int nodeCount)
                {
                    edges.Sort((a, b) => a.Weight.CompareTo(b.Weight)); // Sort edges by weight
                    var parent = Enumerable.Range(0, nodeCount).ToArray(); // Disjoint-set
                    var result = new List<Edge>();

                    int Find(int x)
                    {
                        if (parent[x] != x)
                            parent[x] = Find(parent[x]);
                        return parent[x];
                    }

                    void Union(int x, int y)
                    {
                        parent[Find(x)] = Find(y);
                    }

                    foreach (var edge in edges)
                    {
                        if (Find(edge.From) != Find(edge.To))
                        {
                            result.Add(edge);
                            Union(edge.From, edge.To);
                        }
                    }

                    return result; // Return edges of the MST
                }
            }
        }
    }