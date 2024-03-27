# What is in this Section?

So for HTTPClient Factory, the Page server-side play as a client to interact with another API endpoint. As when Browser user interact with the Page, they don't send the request directly but sending by the Page server.

## Method

| Handler method    | Description                                                                                 |
| ----------------- | ------------------------------------------------------------------------------------------- |
| `OnGet()`         | This method is called when the page is requested using the HTTP GET method.                 |
| `OnPost()`        | This method is called when the page is submitted using the HTTP POST method.                |
| `OnGetAsync()`    | This method is called asynchronously when the page is requested using the HTTP GET method.  |
| `OnPostAsync()`   | This method is called asynchronously when the page is submitted using the HTTP POST method. |
| `OnGetHandler()`  | This method is called when a specific handler is requested using the HTTP GET method.       |
| `OnPostHandler()` | This method is called when a specific handler is requested using the HTTP POST method.      |

**Be aware that PUT, POST, DELET method are all handled by OnPost() method series**
**These request was defined when calling HttpClient method inside the function**

Probably a good way for MicroService.

_I feel my brain is starting overwhelming.
Perhaps next step is to review other server-side structure like Django and Node._
