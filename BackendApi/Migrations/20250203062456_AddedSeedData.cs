using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendApi.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BusinessContactDetails",
                columns: new[] { "ContactID", "Address", "City", "ContactName", "Country", "Phone", "PostalCode" },
                values: new object[,]
                {
                    { 1, "16th Court Dr", "Olympia", "Rogger", "US", "222-555-6666", "98501" },
                    { 2, "16th Court Dr", "Olympia", "Alice", "US", "222-555-6666", "98501" },
                    { 3, "16th Court Dr", "Olympia", "Bob", "US", "222-555-6666", "98501" }
                });

            migrationBuilder.InsertData(
                table: "DynamicContent",
                columns: new[] { "PostId", "Author", "Content", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 1, "Robert", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas tincidunt nibh et nulla pharetra, id euismod velit scelerisque. Ut maximus dui et sem suscipit, a feugiat nisl gravida. Mauris id eros sit amet diam sollicitudin interdum nec at nisl. In ac tortor purus. Sed scelerisque imperdiet lorem in rutrum.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "What does the fox say?" },
                    { 2, "Dillon", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas tincidunt nibh et nulla pharetra, id euismod velit scelerisque. Ut maximus dui et sem suscipit, a feugiat nisl gravida. Mauris id eros sit amet diam sollicitudin interdum nec at nisl. In ac tortor purus. Sed scelerisque imperdiet lorem in rutrum.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Top 10 Chess Duels" },
                    { 3, "Tyler", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas tincidunt nibh et nulla pharetra, id euismod velit scelerisque. Ut maximus dui et sem suscipit, a feugiat nisl gravida. Mauris id eros sit amet diam sollicitudin interdum nec at nisl. In ac tortor purus. Sed scelerisque imperdiet lorem in rutrum.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Basketball Top Basket" }
                });

            migrationBuilder.InsertData(
                table: "FeedbackData",
                columns: new[] { "FeedbackId", "Blogger", "Feedback", "PublishDate" },
                values: new object[,]
                {
                    { 1, "Tyler", "Robert", "11-15-22" },
                    { 2, "Alice", "Donald", "11-15-22" },
                    { 3, "Devin", "Rogger", "11-15-22" }
                });

            migrationBuilder.InsertData(
                table: "StaticContent",
                columns: new[] { "ContentID", "Product", "ProductDes", "Seller" },
                values: new object[,]
                {
                    { 1, "Snuggy", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas tincidunt nibh et nulla pharetra, id euismod velit scelerisque. Ut maximus dui et sem suscipit, a feugiat nisl gravida. Mauris id eros sit amet diam sollicitudin interdum nec at nisl. In ac tortor purus. Sed scelerisque imperdiet lorem in rutrum.", "Donald" },
                    { 2, "Chess", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas tincidunt nibh et nulla pharetra, id euismod velit scelerisque. Ut maximus dui et sem suscipit, a feugiat nisl gravida. Mauris id eros sit amet diam sollicitudin interdum nec at nisl. In ac tortor purus. Sed scelerisque imperdiet lorem in rutrum.", "Randy" },
                    { 3, "Basketball", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas tincidunt nibh et nulla pharetra, id euismod velit scelerisque. Ut maximus dui et sem suscipit, a feugiat nisl gravida. Mauris id eros sit amet diam sollicitudin interdum nec at nisl. In ac tortor purus. Sed scelerisque imperdiet lorem in rutrum.", "Tyson" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BusinessContactDetails",
                keyColumn: "ContactID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BusinessContactDetails",
                keyColumn: "ContactID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BusinessContactDetails",
                keyColumn: "ContactID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DynamicContent",
                keyColumn: "PostId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DynamicContent",
                keyColumn: "PostId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DynamicContent",
                keyColumn: "PostId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FeedbackData",
                keyColumn: "FeedbackId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FeedbackData",
                keyColumn: "FeedbackId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FeedbackData",
                keyColumn: "FeedbackId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StaticContent",
                keyColumn: "ContentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StaticContent",
                keyColumn: "ContentID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StaticContent",
                keyColumn: "ContentID",
                keyValue: 3);
        }
    }
}
