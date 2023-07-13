﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
// Write your JavaScript code.
function search() {
    var obj_data = {
        Country:"",
        CountryCode: $('#CountryCode').val(),
        SearchPhrase: $('#inputSearchPhrase').val(),
        OrderBy: $('#inputOrderBy').val()
    };
    debugger;
    var searchPhase = $('#inputSearchPhrase').val()
    $.ajax({
        url: '/JobSeeker/FilterQuickJobSearch',
        type: 'POST',
        data:JSON.stringify(obj_data),
        contentType: 'application/json',
            success: function (result) {
                $('#jobResults').html(result);
            },
            error: function (xhr,txtStatus,errorThrown) {
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
            $('#jobResults').html(result);
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
