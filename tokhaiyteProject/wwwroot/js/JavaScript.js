var create = create || {};
var provinceId = 0;
create.changeProvince = function (id) {
    create.drawDistrict(id);
}

    create.drawDistrict = function (idProvince) {
        $.ajax({
            url: `/Home/Districts/${idProvince}`,
            method: "GET",
            contentType: "json",
            success: function (data) {
                $("#idDistrict").empty();
                $.each(data.districts, function (i, v) {
                    $("#idDistrict").append(`
                        <option value=${v.id}>${v.districtName}</option>
                    `);
                });
            }
        });
        $("#idWard").empty();
}

create.changeDistrict = function (id) {
    provinceId = $("#ProvinceId").val();
    create.drawWard(id, provinceId);
}

    create.drawWard = function (idDistrict, idProvince) {
        $.ajax({
            url: `/Home/Wards/${idDistrict}/${idProvince}`,
            method: "GET",
            contentType: "json",
            success: function (data) {
                $("#idWard").empty();
                $.each(data.wards, function (i, v) {
                    $("#idWard").append(`
                        <option value=${v.id}>${v.wardName}</option>
                    `);
                });
            }
        });
    }


//$(function () {
//    $("#idProvince").change(function () {
//        var url = "/Home/GetDistricts";
//        var ddlsource = "#idProvince";
//        $.getJSON(url, { id: $(ddlsource).val() }, function (data) {
//            var items = '';
//            $("#idDistrict").empty();
//            $.each(data, function (i, row) {
//                items += "<option value='" + row.value + "'>" + row.text + "</option>";
//            });
//            $("#idDistrict").html(items);

//            var url = "/Home/GetWards";
//            var DistrictVal = "#idDistrict";
//            $.getJSON(url, { id: $(DistrictVal).val() }, function (data) {
//                var items = '';
//                $("#idWard").empty();
//                $.each(data, function (i, row) {
//                    items += "<option value='" + row.value + "'>" + row.text + "</option>";
//                });
//                $("#idWard").html(items);
//            });
//        });
//    });
//}
//);
//$(function () {
//    $("#Districts").change(function () {
//        var url = "/Home/GetWards";
//        var ddlsource = "#Districts";
//        $.getJSON(url, { id: $(ddlsource).val() }, function (data) {
//            var items = '';
//            $("#Wards").empty();
//            $.each(data, function (i, row) {
//                items += "<option value='" + row.value + "'>" + row.text + "</option>";
//            });
//            $("#Wards").html(items);
//        });
//    });
//}
//);