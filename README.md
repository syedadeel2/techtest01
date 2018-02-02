Technical Test 01
=================

Given the solution, please implement the following (Please use your discretion to come up with a solution that you would think is production quality).

Fork the repository and send us your forked URL.


Repository Layer
----------------

- Use Entity Framework (Code First) to implement a IRepository pattern against the [Product] domain object.
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

Angular5 (Bonus)
-------

- Create Angular5 adaptation of the site
- "/angular" : this will display the SPA adaptation of the MVC site

Notes
-----

Continuously commit as you progress through the code.


Stuff we will be looking at:

- Implementation of Entity Framework
- Implementation of data context (preferably a singleton class)
- Configuration and Usage of a DI container, and therefore usage within the Controller
- Url Routing
- Angular 5 implementation

Stuff that isn't important:
- Design (ui, css)
- Database