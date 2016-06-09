.properties: s .trace for loglevel
Tom's context.xml: connection info

~/WebRoot/admin/view.jsp
text.get
	code
		multilang_id.addElement("BUTTON_LABEL");	// query whole slang.screen_id's at topmost; if none and get, 100phenomenon
		<%=text.get("BUTTON_LABEL.read")%>			// use specific screen_id.specifier; if wrong specifier, null
grid.col
	db
		key slang.screen_id, type='b'
		checked implementations of slang.col_type, col_max_len, col_seq etc.
~/src/*/svl/admin/controller.jsp
	code
		gdRes = method(gdReq);
				gdReq.getValue("columnName", i);
				value = ServiceConnector.doService(info, "daoName", "connection", "methodName", obj);
		finally OperateGridData.write(req, res, gdRes, out);
~/../SVC/src/*/svc/admin/dao.java
