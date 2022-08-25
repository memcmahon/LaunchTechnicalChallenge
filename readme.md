# Launch Tech Challenge

There are two pieces to this challenge:

1. A refactoring exercise (in the `refactoring` project)
1. An MVC exercise (in the `nearest-fuel-station` project)

Additional details on each are included below.

We recommend spending **no more than 3 hours** on this challenge.

In order to complete these challenges, clone (don't fork) this repository. Make your changes and commits in your cloned repository.

## Refactoring

The `refactoring` project includes a working CreditCard class that is able to determine whether or not a credit card number is valid using the [Luhn Algorithm](https://en.wikipedia.org/wiki/Luhn_algorithm). There are NUnit tests included in the Refactoring.UnitTests project that confirm this functionality. While the existing code works, it does not demonstrate the best code construction or design.  

Refactor the CreditCard class - make **any** change you want, as long as the existing tests still pass. You _may_ add additional tests.

After you have refactored the CreditCard class, update this document with answers to the following questions:

* It's not uncommon that a student just learning to program would feel comfortable with the code as it was initially provided. How would you describe the necessity of refactoring this class? 
* How would you describe the advantages/disadvantages of your refactored code to a student who is still fairly new to programming?  
* Are there additional changes that you would make, if given more time?

## .NET API Consumption

The `NearestFuelStation` project includes a .NET MVC app with some starter code and a single passing test in the `NearestFuelStation.FunctionalTests` project.

This challenge will use information from the National Renewable Energy Laboratory. Sign up for an API key [here](https://developer.nrel.gov/signup/). If you have any trouble obtaining an API key, please let us know.

Once you have your API key, update the application based on the user story below using the API endpoint documented [here](https://developer.nrel.gov/docs/transportation/alt-fuel-stations-v1/nearest/#station-count-record-fields).

```
As a user
When I visit "/"
And I select "Turing" from the start location drop down (Note: Use the existing search form)
And I click "Find Nearest Electric Station"
Then I should be on page "/search"
And I should see a count of Electric Stations within 5 miles of my location.
And I should see details about the five closest electric fuel stations to Turing, including their:

- Name
- Address
- Fuel Type
- Access Times
```

Once you've finished, answer the questions below in this document.

* At a high level, how did you organize the code that you added? For example, if you added a class or classes, what responsibilities do they have? Are there alternatives you considered or could envision? If so, why did you choose this path instead?
* When teaching web app development, we start by covering standard ReSTful routing, and then present students with less structured challenges like this one.  Sometimes students struggle to go from out-of-the-box code (a new .NET project) to adding non-standard functionality; they try to memorize any patterns instructors provide when going over a challenge like this. What strategies would you recommend to help students understand that there are many different approaches they could take to solve this problem?
* We frequently ask students to focus on their problem solving *process* in lieu of the *outcome* of a timed challenge. At a high level, how would you describe your process to this challenge to a group of students who might not yet be very good at talking about how they go about solving a problem? What strategies could you use to help students begin to articulate their own approach to technical problems?

## Submission

In order to submit, zip this directory, upload it to google drive and email the link to the google drive folder to coree@turing.edu.



