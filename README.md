Technical Test 01
=================

Given the solution, please implement the following (Please use your discretion to come up with a solution that you would think is production quality).

Repository Layer
----------------

- Use Entity Framework to implement a IRepository pattern against the [Product] domain object.
- Implement a data context to link a database (of your choice; this is all code first)

Services Layer
--------------

- Implement the [IProductService] interface

Web Layer
---------

- Use any IoC / DI containers of your choice against the Service Layer
- Using the interfaces, implement the following pages
- "/" (Homepage): this will display two random products
- "/products" (Product List) : this will display a list of product name and image
- "/product/{slug}" (Product Details) : this will display the product details


Notes
-----

Stuff we will be looking at:

- Implementation of Entity Framework
- Implementation of data context (preferably a singleton class)
- Configuration and Usage of a DI container, and therefore usage within the Controller
- Url Routing

Stuff that isn't important:
- Design (ui, css)
- Database