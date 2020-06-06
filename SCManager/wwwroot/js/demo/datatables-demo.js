// Call the dataTables jQuery plugin
$(document).ready(function () {
    $('#dataTable_Users').DataTable({ "order": [[0, "desc"]] });
    $('#dataTable_ComponentTypes').DataTable({ "order": [[1, "desc"]] });
    $('#dataTable_UnitMultipliers').DataTable({ "order": [[0, "desc"]] });
    $('#dataTable_MyComponents').DataTable({ "order": [[0, "desc"]] });

});
