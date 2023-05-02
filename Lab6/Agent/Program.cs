

using Agent.AirTrafficControl;


var mediator = new CommandCentre();

var runway1 = new Runway();
var runway2 = new Runway();

var aircraft1 = new Aircraft("Boeing 747");
var aircraft2 = new Aircraft("Airbus A320");

mediator.RegisterRunways(runway1);
mediator.RegisterRunways(runway2);
mediator.RegisterAircraft(aircraft1);
mediator.RegisterAircraft(aircraft2);

aircraft1.Land(mediator);
aircraft2.Land(mediator);

aircraft1.TakeOff(mediator);
aircraft2.TakeOff(mediator);
