# Hammerhead Interview Development Asssignment

Start by forking this repo and solving the problem with completed instructions for building/running.

When you are done, open a PR against the original hammerheadnav/interview repo when you're finished.

## Instructions

Write a simple program in a language of your choice that implementations for three "services" (Strava, RWGPS, and Komoot).

Either include a program for each method that prints the output or a single program
that runs all four methods and prints thee output (somehow noting which method result it's printing).

### Services

Each service has a call to get routes. If an (optional) user is passed, all routes should be prepended with the user id.

* Strava always returns routes `["SRT", "CVT", "Perkiomen"]`
* RWGPS always returns routes `["CVT", "Perkiomen", "Welsh Mountain"]`
* Komoot always returns routes `["SRT", "Welsh Mountain", "Oaks to Philly"]`

### Methods

The main class should have a few methods:

#### All Routes

This function called on the main class should return the list of the routes across all services.

#### Unique Routes

This function called on the main class should return a *unique* list of the routes across all services.

#### All User Routes

This function should be called with a user id and return a list of all the routes the user has across all services.

#### Users Routes by Service

This function should be called with a user id and a subset of the list of services (e.g. `["Strava", "Komoot"]`) and should
return the user's routes for only the services listed.


## Building/Running

TODO: replace this (this is cheating)

```
echo 'All routes: ["SRT", "CVT", "Perkiomen", "CVT", "Perkiomen", "Welsh Mountain", "SRT", "Welsh Mountain", "Oaks to Philly"]'
echo 'Unique routes: ["SRT", "CVT", "Perkiomen", "Welsh Mountain", "Oaks to Philly"]'
echo 'For user 42: ["42SRT", "42CVT", "42Perkiomen", "42CVT", "42Perkiomen", "42Welsh Mountain", "42SRT", "42Welsh Mountain", "42Oaks to Philly"]'
echo 'For user 42 services ["Komoot", "RWGPS"]: ["42SRT", "42Welsh Mountain", "42Oaks to Philly", "42CVT", "42Perkiomen", "42Welsh Mountain"]'
```