# Intro to C#

The project contains the following elements:
* Delegate
* Event
* List
* Dictionary 
* Lambda Expressions <br />

## Function Container, Single Mission and Combined Mission
In this section, we used the [Command](https://en.wikipedia.org/wiki/Command_pattern) & [Builder](https://en.wikipedia.org/wiki/Builder_pattern) design patterns.<br />
We wanted to define a dictionary of functions (when the key of the mission is a string and the value is a pointer to a function), and to build objects of missions.<br />
* **Basic mission** - activation of a single function.
* **Complex mission** - activation of a composition of functions. <br />

Therefore, we implemented the following classes: <br />
* **FunctionsContainer** - this class contains an indexer which given the name of a function (as a string) returns the corresponding function that receives and returns a single value: 𝒇: ℝ → ℝ.
* **SingleMission** - this class stores one of the functions that are stored in the FunctionsContainer class.
Calling the Calculate method of this class activates the mission. <br />
* **ComposedMission** - this class stores a composition of functions from the functions Which are stored in the FunctionsContainer class.
Calling the Calculate method of this class activates the mission. <br /> <br /> <br />

## Function Container 
![image](https://user-images.githubusercontent.com/45918740/100990479-93ec5580-355a-11eb-8a6b-498157ae3f9c.png)

In the code above we created an instance of the FunctionsContainer class and added functions to it by using Lambda Expressions (functions from the type: 𝒇: ℝ → ℝ only).
Entering a string as an index to the functions container returns the corresponding function. <br /> <br /> <br />

## Mission Interface
Each mission implements the IMission interface. The interface contains:
* Calculate method.
* Event which is triggered when the Calculate method is called.
* 2 fields that indicate the name of the mission and its type.


![image](https://user-images.githubusercontent.com/45918740/100989338-6eab1780-3559-11eb-8b86-8793876b569f.png)
The SingleMission and ComposedMission classes implement this interface. <br /> <br /> <br /> <br />

![image](https://user-images.githubusercontent.com/45918740/100989590-ab770e80-3559-11eb-9f79-0139115cf9a7.png) <br />

In the code above we created a ComposedMission that performs the following calculation: <br />
![image](https://user-images.githubusercontent.com/45918740/100989698-c9dd0a00-3559-11eb-946c-5b473df841d8.png) <br /> <br /> <br />


![image](https://user-images.githubusercontent.com/45918740/100989787-de210700-3559-11eb-8c18-6185c7858362.png) <br />
In the code above we created a ComposedMission that performs the following calculation: <br />
![image](https://user-images.githubusercontent.com/45918740/100989854-f2650400-3559-11eb-8cfe-1a7cbee32c8a.png) <br /> <br /> <br />


![image](https://user-images.githubusercontent.com/45918740/100989887-fb55d580-3559-11eb-921e-d0c6df6b9e98.png) <br />
In the code above we created a SingleMission that performs the following calculation: <br />
![image](https://user-images.githubusercontent.com/45918740/100989934-0a3c8800-355a-11eb-89d3-05cf238ef4d2.png) <br /> <br /> <br />

![image](https://user-images.githubusercontent.com/45918740/100991258-7966ac00-355b-11eb-9860-eb22d6e12930.png) <br />
In the code above we printed all the available functions. <br /> <br /> <br />


![image](https://user-images.githubusercontent.com/45918740/100991421-a4e99680-355b-11eb-89c8-864d5b9c7a7a.png) <br />
In the code above we created a new function named Stam, that does not change the received value, but returns it as it is. <br />
![image](https://user-images.githubusercontent.com/45918740/100991718-fdb92f00-355b-11eb-8966-c0d018a4c208.png) <br />

Therefore, the mission above performs the following calculation: <br />
![image](https://user-images.githubusercontent.com/45918740/100991840-1fb2b180-355c-11eb-9092-f9505a40f422.png) <br /> <br /> <br />

![image](https://user-images.githubusercontent.com/45918740/100992029-5ab4e500-355c-11eb-83d1-7ace8b0bc2bf.png) <br />
In the code above we printed all the available functions, and we can see that Stam function has been added. <br /> <br />

We can change Stam as follows: <br />
![image](https://user-images.githubusercontent.com/45918740/100992180-8b951a00-355c-11eb-9ba3-6ad288793b2e.png)

and create a new mission that performs the following calculation: <br />
![image](https://user-images.githubusercontent.com/45918740/100992335-bc754f00-355c-11eb-9218-51e87d4f2a9b.png)

**Note:** mission4 has not changed as a result of this change. <br /><br /> <br />

## Event Handlers
![image](https://user-images.githubusercontent.com/45918740/100992894-62c15480-355d-11eb-9e20-edc8ffbee878.png) <br />
In the code above we created an EventHandler that when the Calculate function is triggered, writes in the Console the details of the activated mission and its returned value. <br /> <br /> <br />

![image](https://user-images.githubusercontent.com/45918740/100993305-e8dd9b00-355d-11eb-867d-0c53f81d6ce7.png) <br />
In the code above we created an EventHandler that when the Calculate function is triggered, creates a Sqrt mission and executes it as long as the value obtained is > 2. <br />

Since there are 2 different Event Handlers, we link them to Mission through the Event: <br />
![image](https://user-images.githubusercontent.com/45918740/100994458-46261c00-355f-11eb-8d8e-d890efa16a05.png) <br /><br /> <br />

![image](https://user-images.githubusercontent.com/45918740/100994684-84bbd680-355f-11eb-962f-b11af49d5e47.png) <br />
In the code above, we added to the list more instances of the missions. <br />
Then we ran all the missions with the 100 parameter: <br />
![image](https://user-images.githubusercontent.com/45918740/100994901-c482be00-355f-11eb-83b8-895469e1c26c.png) <br />
And we got: <br />
![image](https://user-images.githubusercontent.com/45918740/100995075-f562f300-355f-11eb-9469-63159f22d529.png)<br />
![image](https://user-images.githubusercontent.com/45918740/100995822-f9434500-3560-11eb-8196-2ee042ffa010.png)<br />
![image](https://user-images.githubusercontent.com/45918740/100996553-db2a1480-3561-11eb-9efa-915df1790f7e.png)<br />
![image](https://user-images.githubusercontent.com/45918740/100996221-78d11400-3561-11eb-8202-cb7cd8281d1f.png)<br />






