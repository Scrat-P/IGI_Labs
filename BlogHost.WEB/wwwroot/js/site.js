﻿const commentHubConnection = new signalR.HubConnectionBuilder().withUrl("/comment")
    .configureLogging(signalR.LogLevel.Information).build();

const likeHubConnection = new signalR.HubConnectionBuilder().withUrl("/like")
    .configureLogging(signalR.LogLevel.Information).build();

commentHubConnection.start().catch(function (err) {
    return console.error(err.toString());
});

likeHubConnection.start().catch(function (err) {
    return console.error(err.toString());
});