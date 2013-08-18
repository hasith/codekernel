define(['knockout', 'core/notifier'], function (ko, notifier) {

    return {
        activate: function () {
            notifier.info("Overview component is activated!");
        }
    }
});