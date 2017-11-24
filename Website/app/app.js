
angular.module("GeekChacha", ["ngRoute", "ui.bootstrap", "ui.filters"]).config(["$routeProvider",
  function ($routeProvider) {
      $routeProvider.
          when('/GeekChacha/index', {
              templateUrl: 'views/index.html',
              controller: 'indexCtrl'
          })
          .when('/MotorInspection/PB/InspectionDashboard', {
              templateUrl: 'views/InspectionDashboard.html',
              controller: 'InspectionDashboardCtrl'
          })
          .when('/MotorInspection/Insurer/InsurerUnderwriting', {
              templateUrl: 'views/InsurerUnderwriting.html',
              controller: 'InsurerUnderwritingCtrl'
          })
          .when('/MotorInspection/Insurer/InsurerDashboard', {
              templateUrl: 'views/InsurerDashboard.html',
              controller: 'InsurerDashboardCtrl'
          })
          .when('/MotorInspection/Insurer/InsurerMediaFiles', {
              templateUrl: 'views/InsurerMediaFiles.html',
              controller: 'InsurerUnderwritingCtrl'
          })
          .when('/MotorInspection/Login', {
              templateUrl: 'views/login.html',
              controller: 'LoginCtrl'
          })
           .when('/MotorInspection/Admin/AddNewUser', {
               templateUrl: 'views/addnewuser.html',
               controller: 'UserMgmtCtrl'
           })

          .when('/MotorInspection/ChangePassword', {
              templateUrl: 'views/ChangePassword.html',
              controller: 'ChangePasswordCtrl'
          })

          .when('/MotorInspection/Admin/UserDetails', {
              templateUrl: 'views/UserDetails.html',
              controller: 'UserDetailsController'
          })

          .when('/MotorInspection/Admin/UpdateUserInfo', {
              templateUrl: 'views/UpdateUserInfo.html',
              controller: 'UpdateUserInfoCtrl'
          })
          .otherwise('/MotorInspection/Login', {
              templateUrl: 'views/login.html',
              controller: 'LoginCtrl'
          });
  }]);

