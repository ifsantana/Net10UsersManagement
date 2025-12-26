using System.Collections.Concurrent;
using UsersManagement.Api.Models;
using UsersManagement.Api.Repositories;
using Xunit;

namespace UsersManagement.Api.Tests;

public class UserRepositoryTests
{
    //[Fact]
    //public void Users_InitiallyEmpty()
    //{
    //    var repo = new UserRepository();

    //    Assert.NotNull(repo.Users);
    //    Assert.Empty(repo.Users);
    //}

    //[Fact]
    //public void CanAddAndRetrieveUser()
    //{
    //    var repo = new UserRepository();
    //    var user = new User(1, "Alice", "alice@example.com", 30);

    //    var added = repo.Users.TryAdd(user.Id, user);

    //    Assert.True(added);
    //    Assert.True(repo.Users.TryGetValue(user.Id, out var stored));
    //    Assert.Equal(user, stored);
    //}

    //[Fact]
    //public void AddingDuplicateKeyReturnsFalse()
    //{
    //    var repo = new UserRepository();
    //    var user1 = new User(1, "Alice", "alice@example.com", 30);
    //    var user2 = new User(1, "Bob", "bob@example.com", 25);

    //    Assert.True(repo.Users.TryAdd(user1.Id, user1));
    //    Assert.False(repo.Users.TryAdd(user2.Id, user2));

    //    Assert.True(repo.Users.TryGetValue(1, out var stored));
    //    Assert.Equal(user1, stored);
    //}

    //[Fact]
    //public void CanUpdateUser()
    //{
    //    var repo = new UserRepository();
    //    var user = new User(1, "Alice", "alice@example.com", 30);
    //    repo.Users[user.Id] = user;

    //    var updatedUser = new User(1, "Alice Smith", "alice.smith@example.com", 31);
    //    var result = repo.Users.TryUpdate(1, updatedUser, user);

    //    Assert.True(result);
    //    Assert.True(repo.Users.TryGetValue(1, out var stored));
    //    Assert.Equal(updatedUser, stored);
    //}

    //[Fact]
    //public void CanRemoveUser()
    //{
    //    var repo = new UserRepository();
    //    var user = new User(1, "Alice", "alice@example.com", 30);
    //    repo.Users[user.Id] = user;

    //    var removed = repo.Users.TryRemove(user.Id, out var removedUser);

    //    Assert.True(removed);
    //    Assert.Equal(user, removedUser);
    //    Assert.False(repo.Users.ContainsKey(user.Id));
    //}
}