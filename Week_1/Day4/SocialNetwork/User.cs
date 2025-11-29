using System;
using System.Collections.Generic;
using System.Linq;

public class User
{
    public string Name { get; private set; }
    public int Age { get; private set; }

    public List<User> Friends { get; private set; }
    public List<Post> Posts { get; private set; }

    public User(string name, int age)
    {
        Name = name;
        Age = age;
        Friends = new List<User>();
        Posts = new List<Post>();
    }

    public void AddFriend(User user)
    {
        if (user == this)
        {
            Console.WriteLine(" You cannot add yourself as a friend.");
            return;
        }

        if (Friends.Contains(user))
        {
            Console.WriteLine(" This user is already your friend.");
            return;
        }

        Friends.Add(user);
        Console.WriteLine($"✔ {user.Name} added as a friend!");
    }

    public void RemoveFriend(User user)
    {
        if (!Friends.Contains(user))
        {
            Console.WriteLine(" This user is not in your friend list.");
            return;
        }

        Friends.Remove(user);
        Console.WriteLine($"✔ {user.Name} removed from friends.");
    }

    public void CreatePost(string content)
    {
        if (string.IsNullOrWhiteSpace(content))
        {
            Console.WriteLine(" Post content cannot be empty.");
            return;
        }

        Post post = new Post(this, content);
        Posts.Add(post);
        Console.WriteLine("✔ Post created!");
    }

    public void ShowFeed()
    {
        Console.WriteLine($"\n===== {Name}'s FEED =====");

        List<Post> feedPosts = new List<Post>();

        foreach (var friend in Friends)
            feedPosts.AddRange(friend.Posts);

        feedPosts = feedPosts.OrderByDescending(p => p.CreatedAt).ToList();

        if (feedPosts.Count == 0)
        {
            Console.WriteLine("No posts to show.");
            return;
        }

        foreach (var post in feedPosts)
        {
            Console.WriteLine($" {post.Author.Name} posted: \"{post.Content}\" |  Likes: {post.Likes.Count}");

            foreach (var comment in post.Comments)
            {
                Console.WriteLine($"  comment : {comment.Author.Name}: {comment.Content} | {comment.Likes.Count}");
            }
        }
    }

    public void SuggestFriends()
    {
        var suggestion = Friends
            .SelectMany(f => f.Friends)
            .Where(s => s != this && !Friends.Contains(s))
            .Distinct()
            .ToList();

        Console.WriteLine($"===== Friend Suggestions for {Name} =====");

        if (suggestion.Count == 0)
        {
            Console.WriteLine("No suggestions available.");
            return;
        }

        foreach (var u in suggestion)
            Console.WriteLine($" {u.Name}");
    }
}
