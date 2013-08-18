define(['knockout', 'core/notifier'], function (ko, notifier) {

    return {
        activate: function () {
            notifier.warning("Overview component is activated!");
        }
    }
});