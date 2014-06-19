OpenOrderFramework
==================

A lightweight ASP.NET MVC 5 cart/order framework. It can be customized to handel any type of online shopping. Users can place an order and that order is sent via e-mail to the store's owners

Find out more at http://louiebacaj.com

Most local shops don’t have the fancy infrastructure of say Amazon, but they still want to setup a simple online order system. They want an email with an order that they ship or deliver and they want to actually just charge the order in their own store and don’t want some fancy credit card integration (although I will add that option at some point and is easy enough to add). This web application provides the features needed to place an order online and emails it out with the very basic information about that order. 

Although it was originally designed for local restaurants to receive orders from their website and receive an email with the order it has many other uses and in actuality any type of store can be setup to work with this. 

Key Features:
1)	Designed as an easy way to setup an ASP.NET MVC 5 website/store that can easily take orders. 

2)	Users can place order as a guest or signup and their info will be saved to a SQL Server express database.

3)	Uses bootstrap framework for the UI with a Boostwatch.com theme configured.

4)	Uses Asynchronous controllers in most cases so the app remains responsive.

5)	Uses code first migration to generate the database and setup the models and configure an admin and guest account for maintenance. (admin@gmail.com with pass abc123 for your local testing)

6)	Authentication and authorization system is provided via Identity 2.0 and is simple and secure.

7)	Admin accounts can add groups of items that will be sold.

8)	Admin accounts can modify and add new items for sale 

9)	Admin accounts can view lists of orders track some analytics via D3 charts (work in progress).

10)	Guest account provided out of the box for quick checkout.

11)	Roles available via Identity.

12)	External account login supported such as Google, Facebook, etc. (Work in progress)

13)	Emailing system leverages Mailgun.com but other cloud email services should work fine.

14)	Paging of items on the UI and many other UI libraries such as jQuery used to add UI.

This framework is intended to be backbone of any of local shop’s websites. Although one could easily integrate this with stripe or any other provider currently it just emails everything. It is setup to work well with mailgun but any other emailing system can be used as well and configured via the web.config.
