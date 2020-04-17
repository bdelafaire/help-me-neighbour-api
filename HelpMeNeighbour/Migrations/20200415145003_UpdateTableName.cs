using Microsoft.EntityFrameworkCore.Migrations;

namespace HelpMeNeighbour.Migrations
{
    public partial class UpdateTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdCategory_Ad_IdAd",
                table: "AdCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_AdCategory_Category_IdCategory",
                table: "AdCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_Message_Ad_AdId",
                table: "Message");

            migrationBuilder.DropForeignKey(
                name: "FK_Message_User_AuthorId",
                table: "Message");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_User_IdReviewed",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_User_IdReviewer",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Review",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Message",
                table: "Message");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ad",
                table: "Ad");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdCategory",
                table: "AdCategory");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "user");

            migrationBuilder.RenameTable(
                name: "Review",
                newName: "review");

            migrationBuilder.RenameTable(
                name: "Message",
                newName: "message");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "category");

            migrationBuilder.RenameTable(
                name: "Ad",
                newName: "ad");

            migrationBuilder.RenameTable(
                name: "AdCategory",
                newName: "ad_category");

            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "user",
                newName: "zipcode");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "user",
                newName: "state");

            migrationBuilder.RenameColumn(
                name: "Salt",
                table: "user",
                newName: "salt");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "user",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "user",
                newName: "lastname");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "user",
                newName: "firstname");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "user",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "user",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "user",
                newName: "adress");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "user",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Grade",
                table: "review",
                newName: "grade");

            migrationBuilder.RenameColumn(
                name: "Comment",
                table: "review",
                newName: "comment");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "review",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "IdReviewer",
                table: "review",
                newName: "id_reviewer");

            migrationBuilder.RenameColumn(
                name: "IdReviewed",
                table: "review",
                newName: "id_reviewed");

            migrationBuilder.RenameIndex(
                name: "IX_Review_IdReviewer",
                table: "review",
                newName: "IX_review_id_reviewer");

            migrationBuilder.RenameIndex(
                name: "IX_Review_IdReviewed",
                table: "review",
                newName: "IX_review_id_reviewed");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "message",
                newName: "content");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "message",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "SendedDate",
                table: "message",
                newName: "sended_date");

            migrationBuilder.RenameColumn(
                name: "IdAuthor",
                table: "message",
                newName: "id_author");

            migrationBuilder.RenameColumn(
                name: "IdAd",
                table: "message",
                newName: "id_ad");

            migrationBuilder.RenameIndex(
                name: "IX_Message_AuthorId",
                table: "message",
                newName: "IX_message_AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_Message_AdId",
                table: "message",
                newName: "IX_message_AdId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "category",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "category",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "category",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "ad",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Picture",
                table: "ad",
                newName: "picture");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "ad",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Bonus",
                table: "ad",
                newName: "bonus");

            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "ad",
                newName: "adress");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ad",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "ad",
                newName: "creation_date");

            migrationBuilder.RenameColumn(
                name: "IdCategory",
                table: "ad_category",
                newName: "id_category");

            migrationBuilder.RenameColumn(
                name: "IdAd",
                table: "ad_category",
                newName: "id_ad");

            migrationBuilder.RenameIndex(
                name: "IX_AdCategory_IdCategory",
                table: "ad_category",
                newName: "IX_ad_category_id_category");

            migrationBuilder.AddColumn<string>(
                name: "id_user",
                table: "ad",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "ad",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_user",
                table: "user",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_review",
                table: "review",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_message",
                table: "message",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_category",
                table: "category",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ad",
                table: "ad",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ad_category",
                table: "ad_category",
                columns: new[] { "id_ad", "id_category" });

            migrationBuilder.CreateIndex(
                name: "IX_ad_UserId",
                table: "ad",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ad_user_UserId",
                table: "ad",
                column: "UserId",
                principalTable: "user",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ad_category_ad_id_ad",
                table: "ad_category",
                column: "id_ad",
                principalTable: "ad",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ad_category_category_id_category",
                table: "ad_category",
                column: "id_category",
                principalTable: "category",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_message_ad_AdId",
                table: "message",
                column: "AdId",
                principalTable: "ad",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_message_user_AuthorId",
                table: "message",
                column: "AuthorId",
                principalTable: "user",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_review_user_id_reviewed",
                table: "review",
                column: "id_reviewed",
                principalTable: "user",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_review_user_id_reviewer",
                table: "review",
                column: "id_reviewer",
                principalTable: "user",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ad_user_UserId",
                table: "ad");

            migrationBuilder.DropForeignKey(
                name: "FK_ad_category_ad_id_ad",
                table: "ad_category");

            migrationBuilder.DropForeignKey(
                name: "FK_ad_category_category_id_category",
                table: "ad_category");

            migrationBuilder.DropForeignKey(
                name: "FK_message_ad_AdId",
                table: "message");

            migrationBuilder.DropForeignKey(
                name: "FK_message_user_AuthorId",
                table: "message");

            migrationBuilder.DropForeignKey(
                name: "FK_review_user_id_reviewed",
                table: "review");

            migrationBuilder.DropForeignKey(
                name: "FK_review_user_id_reviewer",
                table: "review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user",
                table: "user");

            migrationBuilder.DropPrimaryKey(
                name: "PK_review",
                table: "review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_message",
                table: "message");

            migrationBuilder.DropPrimaryKey(
                name: "PK_category",
                table: "category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ad",
                table: "ad");

            migrationBuilder.DropIndex(
                name: "IX_ad_UserId",
                table: "ad");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ad_category",
                table: "ad_category");

            migrationBuilder.DropColumn(
                name: "id_user",
                table: "ad");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ad");

            migrationBuilder.RenameTable(
                name: "user",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "review",
                newName: "Review");

            migrationBuilder.RenameTable(
                name: "message",
                newName: "Message");

            migrationBuilder.RenameTable(
                name: "category",
                newName: "Category");

            migrationBuilder.RenameTable(
                name: "ad",
                newName: "Ad");

            migrationBuilder.RenameTable(
                name: "ad_category",
                newName: "AdCategory");

            migrationBuilder.RenameColumn(
                name: "zipcode",
                table: "User",
                newName: "ZipCode");

            migrationBuilder.RenameColumn(
                name: "state",
                table: "User",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "salt",
                table: "User",
                newName: "Salt");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "User",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "lastname",
                table: "User",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "firstname",
                table: "User",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "User",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "User",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "adress",
                table: "User",
                newName: "Adress");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "User",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "grade",
                table: "Review",
                newName: "Grade");

            migrationBuilder.RenameColumn(
                name: "comment",
                table: "Review",
                newName: "Comment");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Review",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id_reviewer",
                table: "Review",
                newName: "IdReviewer");

            migrationBuilder.RenameColumn(
                name: "id_reviewed",
                table: "Review",
                newName: "IdReviewed");

            migrationBuilder.RenameIndex(
                name: "IX_review_id_reviewer",
                table: "Review",
                newName: "IX_Review_IdReviewer");

            migrationBuilder.RenameIndex(
                name: "IX_review_id_reviewed",
                table: "Review",
                newName: "IX_Review_IdReviewed");

            migrationBuilder.RenameColumn(
                name: "content",
                table: "Message",
                newName: "Content");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Message",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "sended_date",
                table: "Message",
                newName: "SendedDate");

            migrationBuilder.RenameColumn(
                name: "id_author",
                table: "Message",
                newName: "IdAuthor");

            migrationBuilder.RenameColumn(
                name: "id_ad",
                table: "Message",
                newName: "IdAd");

            migrationBuilder.RenameIndex(
                name: "IX_message_AuthorId",
                table: "Message",
                newName: "IX_Message_AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_message_AdId",
                table: "Message",
                newName: "IX_Message_AdId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Category",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Category",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Category",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Ad",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "picture",
                table: "Ad",
                newName: "Picture");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Ad",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "bonus",
                table: "Ad",
                newName: "Bonus");

            migrationBuilder.RenameColumn(
                name: "adress",
                table: "Ad",
                newName: "Adress");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Ad",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "creation_date",
                table: "Ad",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "id_category",
                table: "AdCategory",
                newName: "IdCategory");

            migrationBuilder.RenameColumn(
                name: "id_ad",
                table: "AdCategory",
                newName: "IdAd");

            migrationBuilder.RenameIndex(
                name: "IX_ad_category_id_category",
                table: "AdCategory",
                newName: "IX_AdCategory_IdCategory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Review",
                table: "Review",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Message",
                table: "Message",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ad",
                table: "Ad",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdCategory",
                table: "AdCategory",
                columns: new[] { "IdAd", "IdCategory" });

            migrationBuilder.AddForeignKey(
                name: "FK_AdCategory_Ad_IdAd",
                table: "AdCategory",
                column: "IdAd",
                principalTable: "Ad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AdCategory_Category_IdCategory",
                table: "AdCategory",
                column: "IdCategory",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Ad_AdId",
                table: "Message",
                column: "AdId",
                principalTable: "Ad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Message_User_AuthorId",
                table: "Message",
                column: "AuthorId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_User_IdReviewed",
                table: "Review",
                column: "IdReviewed",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_User_IdReviewer",
                table: "Review",
                column: "IdReviewer",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
