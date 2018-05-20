# ProfGyan

Steps set up ProfGyan WebApi.

1) Download the source code.
2) Open the cs file "ProfGyanDBContext.cs.cs" , change the connection string to point 
	to your development database server.
3) In visual studio Goto Tools->NuGet Package Manager ->Package Manager Console.
	Choose default project as "Profgyan.Data" and run the the command "Update-Database" 


4) Build the WebAPI.sln file

5) Host the project "ProfgyanWebApi". for example("http://localhost/ProfGyan")

Steps to use WebApi

1) To register a user :
	POST http://localhost:8081/api/User/Register
	HEADER 
		Content-Type - application/json
	BODY
		{
		  "UserName": "Galib.Gaurav@1",
		  "FirstName": "Galib",
		  "LastName": "Gaurav",
		  "Email": "galibgaurav@gmail.com",
		  "Password": "Gaurav@123",
		  "ConfirmPassword": "Gaurav@123",
		  "LoggedOn": ""
		}
2) To Login a user :
	POST http://localhost:8081/token
	HEADER
		Content-Type - application/x-www-form-urlencoded
	BODY - x-www-form-urlencoded
		   username Galib.Gaurav@1
		   password Gaurav@123
		   grant_type password
		   
3) Example of using a restricted method (ex. GetUserClaims Method)		   
	GET http://localhost:8081/api/GetUserClaims
	HEADER
		Authorization -  Bearer s4m_b-BzOTlbtoOlNI_9efbN3hFzYXOf3pOpuLHp47eRm5AWxWXbd2__7uttfPqrzayOnVYJCm_S8e1OaoE73aumLzBhu9MEyY3euOH-Z1tY2UfT_Coa9pHiymSq_CcBuYmFWWvA0MacmJhe2E-vAoqMD1I-_FxTsC4GetGN8d8NGlHlWRExa4KjP9mBoEi_otwP2cAkU8iRyE8iDYc6PyMf0iPEYf_hoxaKD1ntc1DAKTQoziAPuc-nIcl4P74XoTRe7GqQC2NEhCHeY58IK8ng7ENX43oCT0a4CzhBZu3AP_Ke2YM1PyAE3kokCvfA
