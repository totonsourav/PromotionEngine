# PromotionEngine
E-Promotion Engine 

1. Technology Used: 
Web application : .net core used = 2.0. In front end, react or angular can be used to connect with the back end asp.nt core server.
Class library : .net standard used = 2.0

2. To do for optimisation:

a. Dependency injection have to be used in the next commit to instantiate the classes through constructor injection at a global level.
b. Coupon class funtionalities: 

i.Coupon class can be create as base class which will have the calculation logic based on the assumption that no coupons have been applied,
ii.Each coupon has their own functionality.So, each can derive from the base class and will have its own calculation logic.
iii. At runtime, the instantiation of on of the coupon classes can be done based on the users radio button selecttion.

c. Exceptional handling also has to handled at a global level to have our custom defined exceptions.

**** NOTES: Optimisation points will be updated in this page after each commit analysis.

