# Restaurant Order Management System Project
<h2>Project's Main Purpose</h2>
<p>The SignalR project I developed operates as follows: Users can place orders online from the restaurant or make reservations. To place an online order, users need to log in. Then, they can add any food or drink they want from the menu to their cart.

Orders and reservations are displayed live on the admin panel using SignalR technology without refreshing the page. Admins have the authority to review and either approve or cancel orders and reservations through this live view. Any status change is automatically sent to the relevant user's real email address. This allows both users and admins to track transactions in real-time and be quickly informed of any changes.</p>
<h2>Technical Details</h2>
<p>The project, developed using ASP.NET Core 6.0 SignalR and Web API, performs all CRUD operations via the API, which are then consumed on the MVC side. Entity Framework Code First is used for dynamic database management. The DTO layer ensures safer operations on entities. An N-Tier architecture structure is implemented in the project, prioritizing a more modular and sustainable codebase.</p>
<h2>What is the SignalR</h2>
<p>ASP.NET SignalR is a library that facilitates real-time communication in web applications. SignalR enables servers to send data to clients and clients to send data to servers. This allows for scenarios like real-time notifications, chat applications, and live updates without needing to refresh the page. SignalR automatically uses and selects the most suitable transport methods such as WebSocket, Server-Sent Events (SSE), and Long Polling.</p>
<h2>Technologies Used</h2>
<ul dir="auto">
<li>ASP.NET Core 6.0</li>
<li>N-Tier Architecture</li>
<li>Fluent Validation</li>
<li>AutoMapper</li>
<li>SignalR (Real Time)</li>
<li>HTML, CSS, Bootstrap</li>
<li>MSSQL</li>
<li>RapidAPI ve ApiConsume (Used for API integration)</li>
<li>Entity Framework Core</li>
</ul>
