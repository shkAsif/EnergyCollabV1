// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
// Write your JavaScript code.
function search() {
    var obj_data = {
        Country: "",
        CountryCode: $('#CountryCode').val(),
        SearchPhrase: $('#inputSearchPhrase').val(),
        OrderBy: $('#inputOrderBy').val()
    };
    debugger;
    var searchPhase = $('#inputSearchPhrase').val()
    $.ajax({
        url: '/JobSeeker/FilterQuickJobSearch',
        type: 'POST',
        data: JSON.stringify(obj_data),
        contentType: 'application/json',
        success: function (result) {
            $('#jobResults').html(result);
        },
        error: function (xhr, txtStatus, errorThrown) {
            alert('An error occurred while updating the partial view.');
        }
    });
}
function CompleteSearch() {
    var completeSearch = {
        CountryCode: $("#inputCountry").val(),
        IndustryExperience: $("#inputIndustryExperience").val(),
        EmploymentCategory: $("#inputEmploymentEmploymentCategory").val(),
        Education: $("#inputEducation").val(),
        SalaryAmount: $("#inputSalarySoughtAmount").val(),
        SalaryCurrency: $("#inputSalarySoughtCurrency").val(),
        SummaryOfExperienceCategory: $("#inputExperience").val(),
        OrderBy: $('#inputOrderBy').val(),
        SearchPhrase: $('#inputSearchPhrase').val()
    };
    debugger;
    var searchPhase = $('#inputSearchPhrase').val()
    $.ajax({
        url: '/JobSeeker/CompleteSearchVacancies',
        type: 'POST',
        data: JSON.stringify(completeSearch),
        contentType: 'application/json',
        success: function (result) {
            $('#completeSearchVacancies').html(result);
        },
        error: function (xhr, txtStatus, errorThrown) {
            alert('An error occurred while updating the partial view.');
        }
    });
}
function getComapnies() {

    debugger;


    var searchPhase = $('#inputSearchPhrase').val()
    $.ajax({
        url: '/Client/ClientTabs',
        type: 'GET',
        data: {
            tabId: "1",
        },
        contentType: 'application/json',
        success: function (result) {
            $('#partialListView').html(result);
        },
        error: function (xhr, txtStatus, errorThrown) {
            alert('An error occurred while updating the partial view.');
        }
    });


}
function getUserGroups() {
    debugger;
    var searchPhase = $('#inputSearchPhrase').val()
    $.ajax({
        url: '/Client/ClientTabs',
        type: 'GET',
        data: {
            tabId: "2",
        },
        contentType: 'application/json',
        success: function (result) {
            $('#partialListView').html(result);
        },
        error: function (xhr, txtStatus, errorThrown) {
            alert('An error occurred while updating the partial view.');
        }
    });
}

function getSecurityRights() {
    debugger;
    var searchPhase = $('#inputSearchPhrase').val()
    $.ajax({
        url: '/Client/ClientTabs',
        type: 'GET',
        data: {
            tabId: "3",
        },
        contentType: 'application/json',
        success: function (result) {
            $('#partialListView').html(result);
        },
        error: function (xhr, txtStatus, errorThrown) {
            alert('An error occurred while updating the partial view.');
        }
    });
}

function getTemplates() {
    debugger;
    var searchPhase = $('#inputSearchPhrase').val()
    $.ajax({
        url: '/Client/ClientTabs',
        type: 'GET',
        data: {
            tabId: "4",
        },
        contentType: 'application/json',
        success: function (result) {
            $('#partialListView').html(result);
        },
        error: function (xhr, txtStatus, errorThrown) {
            alert('An error occurred while updating the partial view.');
        }
    });
}
function getCandidateSubscribers() {
    debugger;
    var searchPhase = $('#inputSearchPhrase').val()
    $.ajax({
        url: '/Client/ClientTabs',
        type: 'GET',
        data: {
            tabId: "5",
        },
        contentType: 'application/json',
        success: function (result) {

            $('#partialListView').html(result);
        },
        error: function (xhr, txtStatus, errorThrown) {
            var x = "";
            alert('An error occurred while updating the partial view.');
        }
    });
}