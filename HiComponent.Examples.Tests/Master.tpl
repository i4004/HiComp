import "Controls"
import "EMailControl"

<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
	<meta charset="utf-8" />
	<title></title>
</head>
<body>
	<t:base-input ng-model="UserName" />
	<t:form-text-item data:label="{StringTable.Label}" data:value="{{TestValue}}" />
	<t:message-box data:value="{{AngularMesageBoxText}}" />
	<t:email ng-model="{EmailModelID}" required validate-on="dirty" data:name="{StringTable.LabelEmail}" />
</body>
</html>