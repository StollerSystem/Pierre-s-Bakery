# _Pierre's Bakery_

#### _A C# console app for a bakery_ 09/25/20

#### By _**Ben Stoller**_

## Description

When the user runs the application, they will receive a prompt with a welcome message along with the cost for both Bread and Pastry.
Pierre offers the following deals:
Bread: Buy 2, get 1 free. A single loaf costs $5.
Pastry: Buy 1 for \$2 or 3 for $5.

After pressing a key to continue the user will be presented with a menu.
A user will then be able to specify how many loaves of Bread and how many Pastrys they'd like by typing in commands. 
On the menu it lists all the bread/pastry for sale as well as the number to enter to add it to your cart. 
There are also the commands:
* 's' to view the shopping cart 
* 'c' to clear the cart
* 'm' to see the menu again
* 'd' for when you are done and want to checkout 
Then the checkout display will return the total cost of the order and how much you saved! 

## Specs

* 1 Constructor will create a "Bread" Object

* 2 Constructor will create a "Pastry" Object 

* 3 Get price from Bread based on quantity. Bread: Buy 2, get 1 free. A single loaf costs $5.
  * input: 10
  * output: 35

* 4 Get price from Pastry based on quantity. Pastry: Buy 1 for $2 or 3 for $5.
  * input: 10
  * output: 17

* 5 Create a Bread object with a description 

* 6 Create a Pastry object with a description 

* 7 Add a Bread Object to shopping cart (list)

* 8 Add a Pastry Object to shopping cart (list)

* 9 Method to get contents of bread cart 

* 10 Method to get contents of pastry cart 

* 11 Return the total cost of the order:
    * input: 5 bread and 5 pastry
    * output: 29

## Setup/Installation Requirements

* You will need to download and install .NET Core SDK (Software Development Kit) for your OS if you don't have it already.
* Clone this repo down to your machine 
* Navigate to the "Bakery.Solutions/Bakery.Tests" directory and run "$ dotnet restore" to create obj directories in both production and test projects. Do not touch this code.
* Navigate to the "Bakery.Solutions/Bakery and type the command "$ dotnet run" to run the program!


## Known Bugs



## Support and contact details

https://github.com/StollerSystem

## Technologies Used

VSCode
C#
.NET Core SDK
MSTest


### License

MIT

Copyright (c) 2020 **_{Ben Stoller}_**

