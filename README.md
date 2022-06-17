# 🪜 Perquisites
[Install](https://dotnet.microsoft.com/en-us/download) dotnet 6

# 🏃 Run

```bash
dotnet run
```

## Can you briefly describe the different perspectives between OOP and FP?

### Object oriented programming

Is a programming paradigm where logic is encapsulated into objects that are usually created from a contract / class.
These objects represent usually things in the `real world` & include related properties & methods related to that object.

Allows inheritance from other classes to periodically build up logic for a certain object. 
Where the base class is more generic and can be inherited by more specific the child classes.

### Functional programming

Is a programming paradigm where logic is represented in a small unit of that usually only does a single thing, called a function.
Functions are usually more pure and involve less mutation & state in favor of immutability most of the time. 
Logic is built up by chaining multiple functions together with concepts like currying, high-order functions & state
is usually encapsulated within a closure. 

## Can you briefly describe the most challenging bug you have had to fix? What was the bug, and how did you fix it?

Most challenging would have to be concurrent bugs, One bug I came across was while building out a feature for our .net open-telemetry library for all TrueLayer services.
We wanted a away to track a latency metric that measures a services latency excluding the time taken on any external calls out side of the service.

So dotnet has a built in Activity class used for diagnostics and is used in the open-telemetry library listeners but the listeners are not async safe and it's not really documented
so we missed it and there wasn't really a test case for this edge case, so some of a batch calls where reporting a negative service latency 🤭.

This popped up in the logs as we we're monitoring our changes and it was only happening for MTLS calls mainly, when we discovered this we found the issue we discovered we need a lock
once fixed we deployed the library patch and updated our services to use the latest version of the lib.

We also added additional test cases to cover this edge case, to prevent this error from occurring again.

## What technology or language feature are you most excited about? Why is it exciting to you?

I'm most excited about Rust super cool language is almost memory & thread safe at compile time 🤯.

In the dotnet realm of things .net 6 has some nice features like records, file namespaces but best of all I think
is the addition of pattern matching feature makes code so much cleaner it's amazing!

They still have a way to go on this though on making it fully exhaustive through but sometime soon 🤞

## What is your biggest pet-peeve when reviewing peers (or your own) code?

Formatting and comments.

Formatting should ideally be linted ahead of time in pipeline to validate it but the dotnet fmt is still not perfect.

Comments usually code should be self commenting but it always helps to have comments where the code is ambiguous or where something isn't initial obvious.
We should all make more use of the XML doc comments in dotnet it helps massively with new engineers get up to speed with the code base.

## Can you briefly describe your favorite financial product and why you like it e.g. term deposit, shares, index fund, etc?

I like open banking and crypto believe the technologies will be further standardized and will become future of banking.
Why? Because they are interesting problems and banking / investing is apart of peoples everyday life. 
