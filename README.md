# Hammerhead Interview Development Asssignment

Start by forking this repo and solving the problem with completed instructions for building/running.

Open a PR against the original hammerheadnav/interview repo when you're finished.

## Instructions

Write a simple program in a language of your choice that has implementations for three "services" (Strava, RWGPS, and Komoot).

Results should be printed to standard output after following the build instructions.

### Services

Each service has the ability to get routes. Services can retreive all routes or retrieve routes for a specific user.

#### Strava

* Has fixed routes  `["SRT", "CVT", "Perkiomen"]`
* For user routes, Strave prepends the user id onto the route.

#### RWGPS

* Has fixed routes  `["CVT", "Perkiomen", "Welsh Mountain"]`
* For user routes, RWGPS appends the user id onto the route.

#### Komoot

* Has fixed routes  `["SRT", "Welsh Mountain", "Oaks to Philly"]`
* For user routes, Komoot prepends *and* appends the user id onto the route.

### Results

The code should have the following functionality:

#### All Routes

Return the list of the routes across all services.

#### Unique Routes

Return a *unique* list of the routes across all services.

#### All User Routes

Given a user id and return a list of all the routes the user has across all services.

#### Users Routes by Service

Given a user id and a subset of the list of services (e.g. `["Strava", "Komoot"]`)
return the user's routes for only the services listed.


## Building/Running

TODO: replace this sample output with correct instructions to build and run your program(s)

```
echo 'All routes: ["SRT", "CVT", "Perkiomen", "CVT", "Perkiomen", "Welsh Mountain", "SRT", "Welsh Mountain", "Oaks to Philly"]'
echo 'Unique routes: ["SRT", "CVT", "Perkiomen", "Welsh Mountain", "Oaks to Philly"]'
echo 'For user 42: ["42SRT", "42CVT", "42Perkiomen", "CVT42", "Perkiomen42", "Welsh Mountain42", "42SRT42", "42Welsh Mountain42", "42Oaks to Philly42"]'
echo 'For user 42 services ["Komoot", "RWGPS"]: ["42SRT42", "42Welsh Mountain42", "42Oaks to Philly42", "CVT42", "Perkiomen42", "Welsh Mountain42"]'
```