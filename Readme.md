# OBSOLETE - GridView - How to implement an external filter


<strong>UPDATED:<br /></strong><br />Starting with version 14.2, GridView provides the built-in Search / Find Panel functionality with the capability to locate it outside grid boundaries. This allows accomplishing a similar task with less effort and does not require so much extra code. See the <a href="https://community.devexpress.com/blogs/aspnet/archive/2014/11/19/asp-net-data-grid-enhancements-coming-soon-in-v14-2.aspx">ASP.NET Data Grid: Enhancements</a> post to learn more about this new functionality.<br /><br />This solution is based on the <a href="https://www.devexpress.com/Support/Center/p/T135656">T135656: GridView - How to highlight / select rows according to search criteria</a> implementation:<br />Use <strong>MVCxGridView.FilterExpression</strong> instead of the <strong>MVCxGridView.Selection</strong> API in order to filter data records according to the specified criteria.

<br/>


