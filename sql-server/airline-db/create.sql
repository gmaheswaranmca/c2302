
--  **************************************************************************************
--  Create the PlaneModel table to hold information of plane model.

PRINT 'Creating PlaneModel table...';

CREATE TABLE PlaneModel
( ModelNumber	VARCHAR(10) NOT NULL, 
  ManufacturerName	VARCHAR(50) NOT NULL,
  PlaneRange SMALLINT NOT NULL,
  CruiseSpeed SMALLINT NOT NULL
  
  CONSTRAINT ModelN_pk PRIMARY KEY (ModelNumber)
);


--  **************************************************************************************
--  Create the Pilot table to hold information of pilot.


PRINT 'Creating Pilot table...';

CREATE TABLE Pilot
( PilotID	 INT NOT NULL IDENTITY, 
  FirstName	 VARCHAR(50) NOT NULL,
  LastName   VARCHAR(50) NOT NULL,
  DOB		 DATE NOT NULL,
  HoursFlown SMALLINT NOT NULL
  
  CONSTRAINT PilotId_pk PRIMARY KEY (PilotID)
);


--  **************************************************************************************
--  Create the PlanePilot table to hold information of Plane and Pilot.


PRINT 'Creating PlanePilot...';

CREATE TABLE PlanePilot
( PlaneModel	VARCHAR(10) NOT NULL, 
  PilotID		INT NOT NULL
  
  CONSTRAINT PlaneModel_fk FOREIGN KEY(PlaneModel) REFERENCES PlaneModel(ModelNumber),
  CONSTRAINT PilotID_fk FOREIGN KEY(PilotID) REFERENCES Pilot(PilotID),
  CONSTRAINT planePilot_pk PRIMARY KEY (PilotID, PlaneModel),
);


--  **************************************************************************************
--  Create the PlaneDetail table to hold information of plane.


PRINT 'Creating PlaneDetail...';

CREATE TABLE PlaneDetail
( PlaneID			INT NOT NULL IDENTITY, 
  ModelNumber		VARCHAR(10) NOT NULL,
  RegistrationNo    VARCHAR(10) NOT NULL,
  BuiltYear			SMALLINT NOT NULL,
  FirstClassCapacity SMALLINT NOT NULL,
  EcoCapacity		SMALLINT NOT NULL,
  
  CONSTRAINT PlaneId_pk PRIMARY KEY (PlaneID),
  CONSTRAINT ModelN_fk FOREIGN KEY (ModelNumber) REFERENCES PlaneModel(ModelNumber),
  CONSTRAINT RegNO_uk UNIQUE (RegistrationNo)
);


--  **************************************************************************************
--  Create the Country table to hold information of country.


PRINT 'Creating Country...';

CREATE TABLE Country 
( CountryName	VARCHAR(50) NOT NULL, 
  CountryCode	CHAR(3) NOT NULL, 
  
  CONSTRAINT country_pk PRIMARY KEY (CountryCOde),
  CONSTRAINT Country_name_uk UNIQUE (CountryName)
);


--  **************************************************************************************
--  Create the Airport table to hold information of airport.


PRINT 'Creating Airport table...';

CREATE TABLE Airport
( AirportCode    CHAR(3) NOT NULL PRIMARY KEY,
  AirportName	 VARCHAR(50) NOT NULL,
  ContactNo		 NUMERIC(18,0) NOT NULL,
  Longitude		 FLOAT NOT NULL,
  Latitude		 FLOAT NOT NULL,
  CountryCode    CHAR(3) NOT NULL,
  CONSTRAINT CountryCode_fk FOREIGN KEY (CountryCode) REFERENCES Country(CountryCode)
  
);
 
 

--  **************************************************************************************
--  Create the Flight table to hold information of flight.


PRINT 'Creating Flight table...';

CREATE TABLE Flight
( FlightNo			VARCHAR(10) NOT NULL,
  FlightDepartTo	CHAR(3) NOT NULL,
  FlightArriveFrom	CHAR(3) NOT NULL,
  Distance			INT NOT NULL,
  
  CONSTRAINT FlightNo_pk PRIMARY KEY (FlightNo),
  CONSTRAINT FLightDepartTo_fk FOREIGN KEY (FlightDepartTo) REFERENCES Airport(AirportCode),
  CONSTRAINT FLightArriceFrom_fk FOREIGN KEY (FlightArriveFrom) REFERENCES Airport(AirportCode),
  CONSTRAINT FlightArriveFrom CHECK (FlightArriveFrom != FlightDepartTo)
);


--  **************************************************************************************
--  Create the FlightAttendant table to hold information of flight attendant.


PRINT 'Creating FlightAttendant table...';

CREATE TABLE FlightAttendant
( AttendantID    INT NOT NULL IDENTITY,
  FirstName		 VARCHAR(50) NOT NULL,
  LastName       VARCHAR(50) NOT NULL,
  DOB			 DATE NOT NULL,
  HireDate		 DATE NOT NULL,
  MentorID		 INT NULL,
  
  CONSTRAINT attendantID_pk PRIMARY KEY (AttendantID),
  CONSTRAINT mentorID_fk FOREIGN KEY (MentorID) REFERENCES FlightAttendant(AttendantID), 
);


--  **************************************************************************************
--  Create the FlightInstance table to hold information of flight instance.



PRINT 'Creating FlightInstance table...';

CREATE TABLE FlightInstance
( InstanceID		INT NOT NULL IDENTITY,
  FlightNo			VARCHAR(10) NOT NULL,
  PlaneID			INT NOT NULL,
  PilotAboardID	    INT NOT NULL,
  CoPilotAboardID	INT NOT NULL,
  FSM_AttendantID   INT NOT NULL,
  DateTimeLeave		DATETIME NOT NULL,
  DateTimeArrive    DATETIME NOT NULL,
  
  
  CONSTRAINT InstanceId_pk PRIMARY KEY (InstanceID),
  CONSTRAINT FlightNo_fk FOREIGN KEY (FlightNo) REFERENCES Flight(FlightNo),
  CONSTRAINT PlaneID_fk FOREIGN KEY (PlaneID) REFERENCES PlaneDetail(PlaneID),
  CONSTRAINT PilotAboardId_fk FOREIGN KEY (PilotAboardID) REFERENCES Pilot(PilotID),
  CONSTRAINT CoPilotAboardId_fk FOREIGN KEY (CoPilotAboardID) REFERENCES Pilot(PilotID),
  CONSTRAINT FSM_AttendantID FOREIGN KEY (FSM_AttendantID) REFERENCES FlightAttendant(AttendantID),   
  CONSTRAINT CoPilodAboardId_fk CHECK (CoPilotAboardId !=PilotAboardID),
  CONSTRAINT DateTimeArrive_ck CHECK (DateTimeArrive > DateTimeLeave)
);


--  **************************************************************************************
--  Create the Pilot InstanceAttendant to hold information of instance attendant.

--  This table has a compound primary key consisting of the InstanceID and AttendantID columns.

PRINT 'Creating InstanceAttendant table...';
CREATE TABLE InstanceAttendant
( InstanceID	INT NOT NULL,
  AttendantID   INT NOT NULL,
  
  CONSTRAINT InstanceAttendantID_pk PRIMARY KEY (InstanceID, AttendantID),
  CONSTRAINT InstanceId_fk FOREIGN KEY (InstanceID) REFERENCES FlightInstance(InstanceID),
  CONSTRAINT AttendantId_fk FOREIGN KEY (AttendantID) REFERENCES FlightAttendant(AttendantID)
) ;
