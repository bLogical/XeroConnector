# XeroConnector
The bLogical Xero connector is an Azure API app which lets you query, create and modify different entities such as Accounts, Transactions, Contacts, Invoices and Orders.

[Click here for more information about Azure API apps](http://azure.microsoft.com/en-in/documentation/services/app-service/) 

[Click here for more information about XERO](http://www.xero.com) 

## Installation

### Get developer account
1. Visit [Xero Developer Center](http://developer.xero.com/documentation/getting-started/getting-started-guide/) and follow the Getting started guide.
2. Signup for a free Xero account
3. Create an organization (for your development)

### Create a Xero Application and upload certificate
Xero provides three types of API integration: Private, Public and Partner. The Xero Connector only supports Private authentication, which in turn requires:
* A Certificate
* A Consumer Key
* A Consumer Secret

1. First step is to create certificate key pair (private and public). 
2. Next step is to [create an API Application](http://developer.xero.com/documentation/getting-started/api-application-setup/#title0)
⋅⋅* Create a Private Application
⋅⋅* Upload the public key
