<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
	<xsl:template match="/">
		<html>
			<head>
				<meta charset="utf-8" />
				<title>Group IS7024's Favorite Key Strokes</title>
			</head>
			<body>
				<table style="width:100%;">
					<tr>
						<th>Member Name</th>
						<th>Fav Key Stroke</th>
					</tr>
					<xsl:for-each select="/XMLPage/bestgroups/bestgroup">
						<tr>
							<td></td>
							<td></td>
						</tr>
					</xsl:for-each>
				</table>

			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
