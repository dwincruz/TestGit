// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $('#myTable').DataTable();       
});


$(function () {
    $('#CategoryOfConcernId').select2();
    $('#trigger').select2();
    $('#ConcernedOfficeId').select2();
    $('#GenderId').select2();
    $('#ChannelId').select2();
    $('#NatureOfConcernId').select2();

    //Show Hide Others
    $('#trigger').change(function () {
        var option = $(this).val();
        /*console.log(option);*/        
        if (option == 23) {
            $("#me").show();
        } else {
            $("#me").hide();
        }
    });

    //$("a.file-del").on('click', function (e) {
    //    e.preventDefault();
    //    var id = $(this).data("id"); 
    //    var url = @Url.Action("DeleteFile");
    //    console.log(id);
    //    Swal.fire({
    //        title: 'Are you sure?',
    //        text: "You won't be able to revert this!",
    //        icon: 'warning',
    //        showCancelButton: true,
    //        confirmButtonColor: '#1ab394',
    //        cancelButtonColor: '#d9534f',
    //        confirmButtonText: 'Yes, delete it!'
    //    }).then((result) => {
    //        if (result.isConfirmed) {
    //            $.ajax({
    //                type: "POST",
    //                url: url,
    //                data: { id: id },
    //                dataType: "json",
    //                success: function (result) {
    //                    console.log(result.success);
    //                    Swal.fire({
    //                        title: "Deleted!",
    //                        text: "Your file has been deleted.",
    //                        html: 'This might take a few moments...',
    //                        timerProgressBar: true,
    //                        timer: 1500,
    //                        didOpen: () => {
    //                            location.reload();
    //                        }
    //                    })

    //                },
    //                error: function (req, status, error) {
    //                    console.log(error);
    //                }
    //            });
    //        }
    //    });
    //});
});

document.getElementById("myBtn").onclick = function () {
    var x = document.getElementById("myDIV1");
    var y = document.getElementById("myDIV2");
    var z = document.getElementById("myDIV3");

    if (x.style.display === "none") {
        x.style.display = "block";
        y.style.display = "none";
        z.style.display = "none";
    } else {
        x.style.display = "block";
        y.style.display = "none";
        z.style.display = "none";
    };
    $('#publicModal').modal('show');
}

document.getElementById("myBtn2").onclick = function () {
    var x = document.getElementById("myDIV1");
    var y = document.getElementById("myDIV2");
    var z = document.getElementById("myDIV3");

    if (x.style.display === "none") {
        x.style.display = "none";
        y.style.display = "block";
        z.style.display = "none";
    } else {
        x.style.display = "none";
        y.style.display = "block";
        z.style.display = "none";
    };
    $('#publicModal').modal('show');
}

document.getElementById("myBtn3").onclick = function () {
    var x = document.getElementById("myDIV1");
    var y = document.getElementById("myDIV2");
    var z = document.getElementById("myDIV3");

    if (x.style.display === "none") {
        x.style.display = "none";
        y.style.display = "none";
        z.style.display = "block";
    } else {
        x.style.display = "none";
        y.style.display = "none";
        z.style.display = "block";
    };
    $('#publicModal').modal('show');
}








