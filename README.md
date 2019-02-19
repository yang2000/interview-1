# Hammerhead Interview Development Asssignment

Start by forking this repo and solving the problem with completed instructions for building/running.

Open a PR against the original hammerheadnav/interview repo when you're finished.

## Instructions

Write a simple program in a language of your choice that has implementations for three "services" (Strava, RWGPS, and Komoot).

Results should be printed to standard output after following the build instructions.

### Services

Each service has the ability to get routes. If an (optional) user is passed, all routes should be prepended with the user id.

* Strava always returns routes `["SRT", "CVT", "Perkiomen"]`
* RWGPS always returns routes `["CVT", "Perkiomen", "Welsh Mountain"]`
* Komoot always returns routes `["SRT", "Welsh Mountain", "Oaks to Philly"]`

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
echo 'For user 42: ["42SRT", "42CVT", "42Perkiomen", "42CVT", "42Perkiomen", "42Welsh Mountain", "42SRT", "42Welsh Mountain", "42Oaks to Philly"]'
echo 'For user 42 services ["Komoot", "RWGPS"]: ["42SRT", "42Welsh Mountain", "42Oaks to Philly", "42CVT", "42Perkiomen", "42Welsh Mountain"]'
```