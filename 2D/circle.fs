FeatureScript 1096;
import(path : "onshape/std/geometry.fs", version : "1096.0");

/***
 * Feature first creates a circle on a sketch, then adds arcs on it.
 * 
 * It's all hardcoded, might add query for circle radius and a 
 * circular pattern for the arcs.
***/
annotation { "Feature Type Name" : "Freaking Circle" }
export const frknCircle = defineFeature(function(context is Context, id is Id, definition is map)
    precondition
    {   
    }
    {
        var sketch0 = newSketch(context, id + "sketch0", {
                "sketchPlane" : qCreatedBy(makeId("Top"), EntityType.FACE)
        });
        skCircle(sketch0, "circle", {
                "center" : vector(0, 0) * millimeter,
                "radius" : 50 * millimeter
        });
        skSolve(sketch0);
       
        var sketch1 = newSketch(context, id + "sketch1", {
                "sketchPlane" : qCreatedBy(makeId("Top"), EntityType.FACE)
        });
        var sketch2 = newSketch(context, id + "sketch2", {
                "sketchPlane" : qCreatedBy(makeId("Top"), EntityType.FACE)
        });
        var sketch3 = newSketch(context, id + "sketch3", {
                "sketchPlane" : qCreatedBy(makeId("Top"), EntityType.FACE)
        });
        var sketch4 = newSketch(context, id + "sketch4", {
                "sketchPlane" : qCreatedBy(makeId("Top"), EntityType.FACE)
        });
        var sketch5 = newSketch(context, id + "sketch5", {
                "sketchPlane" : qCreatedBy(makeId("Top"), EntityType.FACE)
        });
        var sketch6 = newSketch(context, id + "sketch6", {
                "sketchPlane" : qCreatedBy(makeId("Top"), EntityType.FACE)
        });
        var sketch7 = newSketch(context, id + "sketch7", {
                "sketchPlane" : qCreatedBy(makeId("Top"), EntityType.FACE)
        });
        var sketch8 = newSketch(context, id + "sketch8", {
                "sketchPlane" : qCreatedBy(makeId("Top"), EntityType.FACE)
        });
        skArc(sketch1, "arc1", {
                "start" : vector(0, 0) * millimeter,
                "mid" : vector(0,50 ) * millimeter,
                "end" : vector(25, 43.38899) * millimeter
        });
        skArc(sketch2, "arc2", {
                "start" : vector(0,0) * millimeter,
                "mid" : vector(-30,30) * millimeter,
                "end" : vector(3, 49.91008) * millimeter
        });
        skArc(sketch3, "arc3", {
                "start" : vector(0, 0) * millimeter,
                "mid" : vector(-40, 25) * millimeter,
                "end" : vector(-17, 47) * millimeter
        });
        skArc(sketch4, "arc4", {
                "start" : vector(0, 0) * millimeter,
                "mid" : vector(-30, -10) * millimeter,
                "end" : vector(-34, 36.7) * millimeter
        });
        skArc(sketch5, "arc5", {
                "start" : vector(0, 0) * millimeter,
                "mid" : vector(-45, -13) * millimeter,
                "end" : vector(-45.5, 20.5) * millimeter
        });
        skArc(sketch6, "arc6", {
                "start" : vector(0, 0) * millimeter,
                "mid" : vector(-30, -32) * millimeter,
                "end" : vector(-49.9, -1.2) * millimeter
        });
        skArc(sketch7, "arc7", {
                "start" : vector(0, 0) * millimeter,
                "mid" : vector(-45, -23) * millimeter,
                "end" : vector(-45.5, -20.5) * millimeter
        });
        skArc(sketch8, "arc8", {
                "start" : vector(0, 0) * millimeter,
                "mid" : vector(-25, -45) * millimeter,
                "end" : vector(-34.6, -36) * millimeter
        });
        skSolve(sketch1);
        skSolve(sketch2);
        skSolve(sketch3);
        skSolve(sketch4);
        skSolve(sketch5);
        skSolve(sketch6);
        skSolve(sketch7);
        skSolve(sketch8);
    });
