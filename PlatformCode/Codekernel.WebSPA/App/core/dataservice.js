define(['breeze'], function (breeze) {

    var apiBaseUrl = 'http://localhost:1471/';

    breeze.NamingConvention.none.setAsDefault();

    var dataService = new breeze.DataService({
        serviceName: apiBaseUrl + 'rest/',
        hasServerMetadata: false
    });

    var action = function (entityName, actionName, entityId, data, success, error) {
        $.ajax({
            url: apiBaseUrl + 'rest/' + entityName + "(" + entityId + ")/" + actionName,
            type: 'POST',
            data: JSON.stringify(data),
            contentType: "application/json",
            success: success,
            error: error
        });
    };

    var remove = function (entityName, entityId, success, error) {
        $.ajax({
            url: apiBaseUrl + 'rest/' + entityName + "(" + entityId + ")",
            type: 'DELETE',
            contentType: "application/json",
            success: success,
            error: error
        });
    };

    var insert = function (entityName, data, success, error) {
        $.ajax({
            url: apiBaseUrl + 'rest/' + entityName,
            data: JSON.stringify(data),
            type: 'POST',
            contentType: "application/json",
            success: success,
            error: error
        });
    };

    var update = function (entityName, data, success, error) {
        $.ajax({
            url: apiBaseUrl + 'rest/' + entityName + "(" + data.Id + ")",
            data: JSON.stringify(data),
            type: 'PUT',
            contentType: "application/json",
            success: success,
            error: error
        });
    };

    return {
        EntityQuery: breeze.EntityQuery,
        EntityManager: new breeze.EntityManager({ dataService: dataService }),
        Predicate: breeze.Predicate,
        insert: insert,
        remove: remove,
        action: action
    };
});