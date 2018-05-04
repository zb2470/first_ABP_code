var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('first_abp_02');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);