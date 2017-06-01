<%@ import namespace="System.Web.Mvc" %>
<%@ import namespace="EPiServer.Core" %>
<%@ import namespace="EPiServer.Web.Mvc.Html" %>
<%@ import namespace="EPiServer.Forms.Core" %>
<%@ import namespace="EPiServer.Forms.Core.Models" %>
<%@ import namespace="EPiServer.Forms.Helpers.Internal" %>
<%@ import namespace="AddOn.Forms.EmailElementBlock.Models" %>

<%@ control language="C#" inherits="ViewUserControl<EmailElementBlock>" %>

<%
    var formElement = Model.FormElement; 
    var labelText = Model.Label;
%>

<% using(Html.BeginElement(Model, new { @class="FormTextbox" + Model.GetValidationCssClasses(), data_f_type="textbox" })) { %>
    <label for="<%: formElement.Guid %>" class="Form__Element__Caption"><%: labelText %></label>
    <input name="<%: formElement.ElementName %>" id="<%: formElement.Guid %>" type="email" class="FormTextbox__Input"
        placeholder="<%: Model.PlaceHolder %>" value="<%: Model.GetDefaultValue() %>" <%: Html.Raw(Model.AttributesString) %> data-f-datainput />

    <%= Html.ValidationMessageFor(Model) %>
    <%= Model.RenderDataList() %>
<% } %>