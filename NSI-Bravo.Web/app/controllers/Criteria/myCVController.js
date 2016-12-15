﻿'use strict';

app.controller('myCVController', ['$scope', '$location', '$timeout', '$routeParams', '$log', 'myCVService', '$route', function ($scope, $location, $timeout, $routeParams, $log, criteriaService, $route) {
    // MY CV TABLE
    $scope.data = new Array();
    $scope.tree_data = new Array();
    var rawTreeData = new Array();
    var data = new Array();
    var tree;
    $scope.my_tree = tree = {};
    var myTreeData = new Array();
    $scope.editCriteriaFull = new Array();





    $scope.links = [{ DESCRIPTION: '', URL: '' }];
    $scope.addNewLink = function () {
        $scope.links.push({ DESCRIPTION: '', URL: '' });
    };
    $scope.resetLinks = function () {
        $scope.links = [{ DESCRIPTION: '', URL: '' }];
    }
    $scope.removeLink = function (id) {
        if ($scope.links.length > 1) {
            $scope.links.splice(id,1);
        }
    }












    $scope.expanding_property = {
        field: "title",
        displayName: "Name",
        sortable: true,
        filterable: true,
        cellTemplate: "<a ng-click = 'user_clicks_branch(row.branch)'>{{row.branch[expandingProperty.field]}}</a>",
    };






    $scope.col_defs = [
        {
            field: "link",
            displayName: "Attachment link",
            sortable: true,
            cellTemplate: "<a href='{{ row.branch[col.field] }}' >Download</a>",
            sortingType: "number",
            filterable: true
        },
        {
            field: "Actions",
            displayName: "Actions",
            cellTemplate: "<button ng-click='cellTemplateScope.clickEdit(row.branch)' class='btn btn-warning btn-xs' data-toggle='modal' data-target='#editCrModal' >Edit</button>" + " " + "<button ng-click='cellTemplateScope.clickDel(row.branch)' class='btn btn-danger btn-xs' data-toggle='modal' data-target='#delCrModal'  >Delete</button>",
            cellTemplateScope: {
                clickEdit: function (branch) {
                    $scope.editCr = branch;
                    console.log(branch.links);
                    $scope.links = [];
                    for (var i = 0; i < branch.links.length; i++) {
                        $scope.links.push({ DESCRIPTION: branch.links[i].description, URL: branch.links[i].url });
                    }
                    criteriaService.GetCriteria(branch.criteria_id).then(function (response) {
                        $scope.editCriteriaFull = response.data;
                        $scope.editCriteria = $scope.editCriteriaFull.name;
                        console.log($scope.editCriteriaFull.name);
                    });

                },
                clickDel: function (branch) {
                    $scope.delCr = branch;
                    criteriaService.GetCriteria(branch.criteria_id).then(function (response) {
                        $scope.delCriteriaFull = response.data;
                        $scope.delCriteria = $scope.editCriteriaFull.name;
                        console.log($scope.editCriteriaFull.name);
                    });
                }
            }
        }
    ];

    $scope.my_tree_handler = function (branch) {
        console.log('you clicked on', branch);
    }

    function clearTable() {
        $scope.data = [];
        $scope.tree_data = [];
        rawTreeData = [];
        data = [];
        $scope.my_tree = tree = {};
        myTreeData = [];
    };

    function GetMyCVs() {
        clearTable();
        // HARDCODED 3, SHOULD BE FIXED IN BACKEND TO RETURN FOR CURRENT USER - > When login system is implemented
        criteriaService.GetMyCVs(2).then(function (response) {
            data = response.data;
            for (var i = 0; i < data.length; i++) {
                var cv_item = {
                    id: "",
                    title: "",
                    description: "",
                    link: "",
                    user_cv_id: "",
                    criteria_id: "",
                    start_date: "",
                    end_date: "",
                    links: []
                }
                cv_item.id = data[i].iD_ITEM;
                cv_item.title = data[i].name;
                cv_item.description = data[i].description;
                cv_item.link = data[i].attachmenT_LINK;
                cv_item.user_cv_id = data[i].cV_TABLE_ID_CV;
                cv_item.criteria_id = data[i].criteriA_ID_CRITERIA;
                cv_item.links = data[i].attachment;
                

                var date = moment(data[i].starT_DATE).format("YYYY-MM-DD");
                cv_item.start_date = date;
                date = moment(data[i].enD_DATE).format("YYYY-MM-DD");
                cv_item.end_date = date;
                /*
                    var date = moment(data[i].datE_CREATED).format("DD-MM-YYYY");
                    if (date !== null)
                        criterion.created = date;
                */
                if (cv_item.title != null) {
                    rawTreeData.push(cv_item);
                }
            }
            myTreeData = rawTreeData;
                //getTree(rawTreeData, 'id', 'parent_id');
            $scope.tree_data = myTreeData;
        });
    };

    GetMyCVs();
    // MY CV TABLE END


    //MYcv Edit Criteria Choose
    $scope.tree_dataCrit = new Array();
    var rawTreeDataCrit = new Array();
    var treeCrit;
    $scope.my_treeCrit = treeCrit = {};
    var myTreeDataCrit = new Array();

    // Tree for Criteria
    $scope.expanding_propertyCrit = {
        field: "title",
        displayName: "Name",
        sortable: true,
        filterable: true,
        cellTemplate: "<a ng-click = 'user_clicks_branch(row.branch)'>{{row.branch[expandingProperty.field]}}</a>"
    };

    $scope.col_defsCrit = [
        {
            field: "created",
            displayName: "Created",
            sortable: true,
            sortingType: "number",
            filterable: true
        },
        {
            field: "points",
            displayName: "Points",
            sortable: true,
            sortingType: "number"
        },
        {
            field: "Actions",
            displayName: "Actions",
            cellTemplate: "<button ng-click='cellTemplateScope.clickAdd(row.branch)' class='btn btn-primary btn-xs' data-toggle='modal' data-target='#criteriaChoiceModal' >Select</button>",
            cellTemplateScope: {
                clickAdd: function (branch) {
                    criteriaService.GetCriteria(branch.id).then(function (response) {
                        $scope.editCriteriaFull = response.data;
                        $scope.editCriteria = $scope.editCriteriaFull.name;
                        console.log($scope.editCriteriaFull.name);
                    });
                }
            }
        }
    ];

    $scope.my_tree_handler = function (branch) {
        console.log('you clicked on', branch);
    }

    function clearTableCrit() {
        $scope.dataCrit = [];
        $scope.tree_dataCrit = [];
        rawTreeDataCrit = [];
        data = [];
        $scope.my_treeCrit = tree = {};
        myTreeDataCrit = [];
    };

    function GetAllCriteria() {

        clearTableCrit();

        criteriaService.GetAllCriteria().then(function (response) {

            var data = response.data;
            for (var i = 0; i < data.length; i++) {

                var criterion = {
                    id: "",
                    title: "",
                    parent_id: "",
                    created: "",
                    points: ""
                }
                criterion.id = data[i].iD_CRITERIA;
                criterion.title = data[i].name;
                criterion.parent_id = data[i].parenT_CRITERIA;
                var date = moment(data[i].datE_CREATED).format("YYYY-MM-DD");
                if (date !== null)
                    criterion.created = date;
                criterion.points = data[i].points;
                if (criterion.title != null) {
                    rawTreeDataCrit.push(criterion);
                }
            }
            console.log(rawTreeData);
            myTreeDataCrit = getTree(rawTreeDataCrit, 'id', 'parent_id');
            $scope.tree_dataCrit = myTreeDataCrit;
        });
    };

    GetAllCriteria();

    function getTree(data, primaryIdName, parentIdName) {

        if (!data || data.length == 0 || !primaryIdName || !parentIdName)
            return [];

        var tree = [],
            rootIds = [],
            item = data[0],
            primaryKey = item[primaryIdName],
            treeObjs = {},
            parentId,
            parent = {},
            len = data.length,
            i = 0;

        while (i < len) {
            item = data[i++];
            primaryKey = item[primaryIdName];
            treeObjs[primaryKey] = item;
            parentId = item[parentIdName];

            if (parentId) {
                parent = treeObjs[parentId];
                if (parent.children) {
                    parent.children.push(item);
                } else {
                    parent.children = [item];
                }
            } else {
                rootIds.push(primaryKey);
            }
        }

        for (var i = 0; i < rootIds.length; i++) {
            tree.push(treeObjs[rootIds[i]]);
        };
        return tree;
    }
    // Tree for CriteriaEnd





    //MYCV Edit Criteria Choose END

    $scope.editCVItem = function (cr, file) {
        var data = {};
        data.ID_ITEM = cr.id;
        data.NAME = cr.title;
        data.DESCRIPTION = cr.description;
        data.START_DATE = cr.start_date;
        data.END_DATE = cr.end_date;
        data.CRITERIA_ID_CRITERIA = $scope.editCriteriaFull.iD_CRITERIA;


        data.LINKS = JSON.stringify(angular.copy($scope.links));
        data.file = file;

        // FORCED FOR THE MOMENT
        data.CV_TABLE_ID_CV = 2;
        data.STATUS_ID = 2;
        // END OF FORCED DATA
        criteriaService.EditCVItem(cr.id,data).then(function (response) {
            $log.log(response);
            $scope.clearForm();
            GetAllCriteria();
            GetMyCVs();
        });
    };

    $scope.first = "Criteria";
    $scope.second = "Subcategory";
    $scope.selectedCr;
    $scope.firstCriteria = [];
    $scope.secondCriteria = [];

    $scope.clearForm = function () {
        //clear form
        $scope.cr = {};
        $scope.first = "Criteria";
        $scope.second = "Subcategory";
        $scope.selectedCr = null;
        $scope.secondCriteria = [];
        $scope.firstCriteria = [];
    };


    $scope.delCVItem = function (cr) {
        criteriaService.DeleteCVItem(cr.id).then(function (response) {
            $log.log(response);
            GetMyCVs();
        });
    };




    //END DeleteCriteria

}]);