using Microsoft.EntityFrameworkCore.Migrations;

namespace SCManager.Data.Migrations
{
    public partial class AddedAboutText : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "StaticSiteInfos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Content",
                value: @"<h2>About</h2>
<p>SCManager is semiconductors manager application.</p>
<p>Have fun using our product!</p>
<p>&nbsp;</p>
<p>Best regards, The SCManager team</p>
<p>&nbsp;</p>
<p>This about info is effective as of 2 June 2020.</p>");

            migrationBuilder.UpdateData(
                table: "StaticSiteInfos",
                keyColumn: "Id",
                keyValue: 6,
                column: "Content",
                value: @"<h2>Privacy Policy</h2>
<p>Your privacy is important to us. It is SCManager's policy to respect your privacy regarding any information we may collect from you across our website, <a href=""http://www.scmanager.com/"">http://www.scmanager.com/</a>, and other sites we own and operate.</p>
<p>We only ask for personal information when we truly need it to provide a service to you. We collect it by fair and lawful means, with your knowledge and consent. We also let you know why we’re collecting it and how it will be used.</p>
<p>We only retain collected information for as long as necessary to provide you with your requested service. What data we store, we’ll protect within commercially acceptable means to prevent loss and theft, as well as unauthorized access, disclosure, copying, use or modification.</p>
<p>We don’t share any personally identifying information publicly or with third-parties, except when required to by law.</p>
<p>Our website may link to external sites that are not operated by us. Please be aware that we have no control over the content and practices of these sites, and cannot accept responsibility or liability for their respective privacy policies.</p>
<p>You are free to refuse our request for your personal information, with the understanding that we may be unable to provide you with some of your desired services.</p>
<p>Your continued use of our website will be regarded as acceptance of our practices around p
rivacy and personal information. If you have any questions about how we handle user data and personal information, feel free to contact us.</p>
<p>This policy is effective as of 2 June 2020.</p>
<p><a href=""https://getterms.io"" title=""Generate a free privacy policy"">Privacy Policy created with GetTerms.</a></p>
");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "StaticSiteInfos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Content",
                value: @"&lt;h2&gt;About&lt;/h2&gt;
&lt;p&gt;SCManager is a semiconductors management application,&lt;/p&gt;
&lt;p&gt;which can also be used for a Bayesian analysis.&lt;/p&gt;
&lt;p&gt;&amp;nbsp;&lt;/p&gt;
&lt;h2&gt;Thank your for using our application!&lt;/h2&gt;
&lt;p&gt;This about info is effective as of 28 May 2020.&lt;/p&gt;");

            migrationBuilder.UpdateData(
                table: "StaticSiteInfos",
                keyColumn: "Id",
                keyValue: 6,
                column: "Content",
                value: @"&lt;h2&gt;Privacy Policy&lt;/h2&gt;
&lt;p&gt;Your privacy is important to us. It is SCManager's policy to respect your privacy regarding any information we may collect from you across our website, &lt;a href=""http://www.scmanager.com""&gt;http://www.scmanager.com&lt;/a&gt;, and other sites we own and operate.&lt;/p&gt;
&lt;p&gt;We only ask for personal information when we truly need it to provide a service to you. We collect it by fair and lawful means, with your knowledge and consent. We also let you know why we’re collecting it and how it will be used.&lt;/p&gt;
&lt;p&gt;We only retain collected information for as long as necessary to provide you with your requested service. What data we store, we’ll protect within commercially acceptable means to prevent loss and theft, as well as unauthorized access, disclosure, copying, use or modification.&lt;/p&gt;
&lt;p&gt;We don’t share any personally identifying information publicly or with third-parties, except when required to by law.&lt;/p&gt;
&lt;p&gt;Our website may link to external sites that are not operated by us. Please be aware that we have no control over the content and practices of these sites, and cannot accept responsibility or liability for their respective privacy policies.&lt;/p&gt;
&lt;p&gt;You are free to refuse our request for your personal information, with the understanding that we may be unable to provide you with some of your desired services.&lt;/p&gt;
&lt;p&gt;Your continued use of our website will be regarded as acceptance of our practice
s around privacy and personal information. If you have any questions about how we handle user data and personal information, feel free to contact us.&lt;/p&gt;
&lt;p&gt;This policy is effective as of 28 May 2020.&lt;/p&gt;
&lt;p&gt;&lt;a href=""https://getterms.io"" title=""Generate a free privacy policy""&gt;Privacy Policy created with GetTerms.&lt;/a&gt;&lt;/p&gt;
");
        }
    }
}
