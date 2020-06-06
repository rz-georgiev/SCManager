// Call the dataTables jQuery plugin
$(document).ready(function() {
    $('#dataTable_Users').DataTable({
        "order": [[2, "desc"]] 
    });
    $('#dataTable_ComponentTypes').DataTable({
        "order": [[0, "desc"]]
    });
    $('#dataTable_UnitMultipliers').DataTable({
        "order": [[0, "desc"]]
    });
});
