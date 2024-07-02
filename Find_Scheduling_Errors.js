//each user can only be assigned one location per day (so if user and date are the same...then error)
//each location can only be assigned one user per day (so if date and location are the same...then error)

let routes = [
    {
        userIdentifier: "1",
        date: "07-01-2024",
        location: "Cleveland"
    },
    {
        userIdentifier: "1",
        date: "07-02-2024",
        location: "Akron"
    },
    {
        userIdentifier: "2",
        date: "07-02-2024",
        location: "Cleveland"
    },
    {
        userIdentifier: "1",
        date: "07-03-2024",
        location: "Richfield"
    },
    {
        userIdentifier: "3",
        date: "07-01-2024",
        location: "Richfield"
    },
    {
        userIdentifier: "1",
        date: "07-03-2024",
        location: "Cleveland"
    },
    {
        userIdentifier: "2",
        date: "07-03-2024",
        location: "Cleveland"
    },
    {
        userIdentifier: "2",
        date: "07-03-2024",
        location: "Akron"
    },
]


function findErrors (routes) {
    let errors = 0;

    for (let i = 0; i < routes.length-1; i++) {
        for (let j = i+1; j < routes.length; j++) {
            if (routes[i].userIdentifier == routes[j].userIdentifier) { //if the usersare the same...
                if (routes[i].date == routes[j].date) {                 //and the date is the same..
                    errors++;                                           //record error
                }
            }
            if (routes[i].location == routes[j].location) {             //if the locations are the same..
                if (routes[i].date == routes[j].date) {                 //and the date is the same..
                    errors++;                                           //record error
                }
            }
        }
    }

    return errors;
}