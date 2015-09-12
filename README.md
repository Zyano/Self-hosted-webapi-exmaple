# Self-hosted-webapi-exmaple
Example of self hosted web api 2.2 using C#
This allows the developer to host a basic web server out side of the IIS envoriment.
The webserver in this case is the controlled through the HTTPConfiguration and the statup class.

# Expanding and adding more controllers
Any class that inheriets from the ApiController class will be treated as a new subset of api functions
because of the definition of "api/{controller}/" found inside the Startup class.

