<?xml version="1.0" encoding="utf-8" ?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
    <xsl:template match="/">
        <xsl:apply-templates />
    </xsl:template>
    
   <xsl:template match="rss">
      <html>
        <body bgcolor="#ffffff">
            <xsl:apply-templates />
        </body>
      </html>
   </xsl:template>
    
   <xsl:template match="channel">
        <table width="640">
            <xsl:for-each select="item">
                <tr>
                    <td>
                        <a href="{link}"><xsl:value-of select="title" /></a>
                    </td>
                </tr>
            </xsl:for-each>
        </table>
   </xsl:template>
</xsl:stylesheet>
