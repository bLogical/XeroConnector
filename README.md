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

### Publish the Xero Connector to Azure
1. Browse to the [Azure portal](http://portal.azure.com)
2. In the lower left corner, click the plus button
3. In the "create" blade, click "Web & Mobile"
4. Click API App in the next pane, set the name (Eg XeroConnector) and continue with your subscription settings
5. Click "Create" to create the API App
6. When the API has been created, view the details
7. On the API APP blade, click the All settings -> Application settings if you want to change the access level
8. On the API APP blade, click the API app host link, to open the host blade
9. On the API HOST APP blade, click the All settings -> Custom domains and SSL
10. Upload your private key (pfx), and copy the thumbprint
11. Add the following Application settings:


| Key                            | Value                                  |
| ------------------------------ |:--------------------------------------:|
| ConsumerKey                    | Your Xero Application Connsumer Key    |
| ConsumerSecret                 | Your Xero Application Connsumer Secret |
| CertificateThumbprint          | The thumbprint you copied in step 10   |
| WEBSITE_LOAD_CERTIFICATES      | The thumbprint you copied in step 10   |
