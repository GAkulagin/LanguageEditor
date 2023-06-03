/*
*  Copyright (C) 1998-2023 by Northwoods Software Corporation. All Rights Reserved.
*/

/*
* This is an extension and not part of the main GoDiagram library.
* Note that the API for this class may change with any version, even point releases.
* If you intend to use an extension in production, you should copy the code to your own source directory.
* Extensions can be found in the GoDiagram repository (https://github.com/NorthwoodsSoftware/GoDiagram/tree/main/Extensions).
* See the Extensions intro page (https://godiagram.com/intro/extensions.html) for more information.
*/

using System;
using System.Collections.Generic;
using System.Linq;

// This file holds definitions of all standard shape figures -- string values for Shape.Figure.
// You do not need to load this file in order to use named Shape figure.

// The following figures are built-in to the library and thus do not need to be redefined:
//   Rectangle, Square, RoundedRectangle, Border, Ellipse, Circle,
//   TriangleRight, TriangleDown, TriangleLeft, TriangleUp, Triangle,
//   LineH, LineV, None, BarH, BarV, MinusLine, PlusLine, XLine
// If you need any of the other figures that are defined in this file, we suggest that you copy
// just those definitions into your own code.  Do not load this file unless you really want to
// define a lot of code that your app does not use and will not get garbage-collected.

namespace Northwoods.Go.Extensions
{
    // The following functions and variables are used throughout this file:
    /// <summary>
    /// This FigureParameter class describes various properties each parameter uses in figures.
    /// </summary>
    internal class FigureParameter
    {
        public static Dictionary<string, List<FigureParameter>> DefinedParameters = new Dictionary<string, List<FigureParameter>>(StringComparer.OrdinalIgnoreCase);
        private string _Name;
        private double _DefaultValue;
        private double _Minimum;
        private double _Maximum;

        public FigureParameter(string name, double def, double min = 0.0, double max = double.PositiveInfinity)
        {
            _Name = name;
            _DefaultValue = def;
            _Minimum = min;
            _Maximum = max;
        }

        /// <summary>
        /// Gets or sets the name of the figure.
        /// </summary>
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (value == null || value == "") throw new ArgumentException("Shape name must be a valid string.");
                _Name = value;
            }
        }

        /// <summary>
        /// Gets or sets the default value for the parameter.
        /// </summary>
        public double DefaultValue
        {
            get
            {
                return _DefaultValue;
            }
            set
            {
                if (double.IsNaN(value)) throw new ArgumentException("The default value must be a real number, not: " + value);
                _DefaultValue = value;
            }
        }

        /// <summary>
        /// Gets or sets the minimum value allowed for the figure parameter.
        /// </summary>
        public double Minimum
        {
            get
            {
                return _Minimum;
            }
            set
            {
                if (double.IsNaN(value)) throw new ArgumentException("Minimum must be a real number, not: " + value);
                _Minimum = value;
            }
        }

        /// <summary>
        /// Gets or sets the maximum value allowed for the figure parameter.
        /// </summary>
        public double Maximum
        {
            get
            {
                return _Maximum;
            }
            set
            {
                if (double.IsNaN(value)) throw new Exception("Maximum must be a real number, not: " + value);
                _Maximum = value;
            }
        }

        /// <summary>
        /// This static function gets a FigureParameter for a particular figure name.
        /// </summary>
        /// <param name="figurename"></param>
        /// <param name="index">currently must be either 0 or 1</param>
        public static FigureParameter GetFigureParameter(string figurename, int index)
        {
            var arr = DefinedParameters[figurename];
            if (arr == null) return null;
            return arr[index];
        }

        /// <summary>
        /// This static function sets a FigureParameter for a particular figure name.
        /// </summary>
        /// <param name="figurename"></param>
        /// <param name="index">currently must be either 0 or 1</param>
        /// <param name="figparam"></param>
        public static void SetFigureParameter(string figurename, int index, FigureParameter figparam)
        {
            if (figparam == null) throw new Exception("Third argument to FigureParameter.SetFigureParameter is not FigureParameter: " + figparam);
            if (figparam.DefaultValue < figparam.Minimum || figparam.DefaultValue > figparam.Maximum)
            {
                throw new Exception("DefaultValue must be between minimum and maximum, not: " + figparam.DefaultValue);
            }
            List<FigureParameter> arr;
            if (DefinedParameters.ContainsKey(figurename))
            {
                arr = DefinedParameters[figurename];
            }
            else
            {
                arr = new List<FigureParameter>();
                DefinedParameters.Add(figurename, arr);
            }
            arr.Insert(index, figparam);
        }
    }

    /// <summary>
    /// This class contains static methods pertaining to <see cref="Shape"/> figures.
    /// </summary>
    public class Figures
    {
        private static Point GetIntersection(double p1x, double p1y, double p2x, double p2y, double q1x, double q1y, double q2x, double q2y, out Point result)
        {
            var dx1 = p1x - p2x;
            var dx2 = q1x - q2x;
            var x = double.NaN;
            var y = double.NaN;
            if (dx1 == 0)
            {
                if (dx2 == 0)
                {
                    if (p1x == p2x)
                    {
                        x = p1x;
                        y = p1y;
                    }
                }
                else
                {
                    var m2 = (q1y - q2y) / dx2;
                    var b2 = q1y - m2 * q1x;
                    x = p1x;
                    y = m2 * x + b2;
                }
            }
            else
            {
                if (dx2 == 0)
                {
                    var m1 = (p1y - p2y) / dx1;
                    var b1 = p1y - m1 * p1x;
                    x = q1x;
                    y = m1 * x + b1;
                }
                else
                {
                    var m1 = (p1y - p2y) / dx1;
                    var m2 = (q1y - q2y) / dx2;
                    var b1 = p1y - m1 * p1x;
                    var b2 = q1y - m2 * q1x;
                    x = (b2 - b1) / (m1 - m2);
                    y = m1 * x + b1;
                }
            }

            result = new Point(x, y);
            return result;
        }

        private static void BreakUpBezier(double startx, double starty, double c1x, double c1y, double c2x, double c2y, double endx, double endy, double fraction,
                                          out Point curve1cp1, out Point curve1cp2, out Point midpoint, out Point curve2cp1, out Point curve2cp2)
        {
            var fo = 1 - fraction;
            var so = fraction;
            var m1x = (startx * fo + c1x * so);
            var m1y = (starty * fo + c1y * so);
            var m2x = (c1x * fo + c2x * so);
            var m2y = (c1y * fo + c2y * so);
            var m3x = (c2x * fo + endx * so);
            var m3y = (c2y * fo + endy * so);
            var m12x = (m1x * fo + m2x * so);
            var m12y = (m1y * fo + m2y * so);
            var m23x = (m2x * fo + m3x * so);
            var m23y = (m2y * fo + m3y * so);
            var m123x = (m12x * fo + m23x * so);
            var m123y = (m12y * fo + m23y * so);

            curve1cp1 = new Point(m1x, m1y);

            curve1cp2 = new Point(m12x, m12y);

            midpoint = new Point(m123x, m123y);

            curve2cp1 = new Point(m23x, m23y);

            curve2cp2 = new Point(m3x, m3y);
        }

       
        /// <summary>
        /// Define extra figures to be used by <see cref="Shape"/>s.
        /// </summary>
        public static void DefineExtraFigures()
        {
            var GeneratorEllipseSpot1 = new Spot(0.156, 0.156);
            var GeneratorEllipseSpot2 = new Spot(0.844, 0.844);
            var KAPPA = 4 * ((Math.Sqrt(2) - 1) / 3);

            FigureParameter.SetFigureParameter("FramedRectangle", 0, new FigureParameter("ThicknessX", 8));
            FigureParameter.SetFigureParameter("FramedRectangle", 1, new FigureParameter("ThicknessY", 8));
            Shape.DefineFigureGenerator("FramedRectangle", (shape, w, h) => {
                var param1 = (shape != null) ? shape.Parameter1 : double.NaN;
                var param2 = (shape != null) ? shape.Parameter2 : double.NaN;
                if (double.IsNaN(param1)) param1 = 8;  // default values PARAMETER 1 is for WIDTH
                if (double.IsNaN(param2)) param2 = 8;  // default values PARAMETER 2 is for HEIGHT
                var geo = new Geometry();
                var fig = new PathFigure(0, 0, true);
                geo.Add(fig);
                // outer rectangle, clockwise
                fig.Add(new PathSegment(SegmentType.Line, w, 0));
                fig.Add(new PathSegment(SegmentType.Line, w, h));
                fig.Add(new PathSegment(SegmentType.Line, 0, h).Close());
                if (param1 < w / 2 && param2 < h / 2)
                {
                    // inner rectangle, counter-clockwise
                    fig.Add(new PathSegment(SegmentType.Move, param1, param2));  // subpath
                    fig.Add(new PathSegment(SegmentType.Line, param1, h - param2));
                    fig.Add(new PathSegment(SegmentType.Line, w - param1, h - param2));
                    fig.Add(new PathSegment(SegmentType.Line, w - param1, param2).Close());
                }
                geo.SetSpots(0, 0, 1, 1, param1, param2, -param1, -param2);
                return geo;
            });

            FigureParameter.SetFigureParameter("Parallelogram", 0, new FigureParameter("Indent", .1, -.99, .99));
            Shape.DefineFigureGenerator("Parallelogram", (shape, w, h) => {
                var param1 = (shape != null) ? shape.Parameter1 : double.NaN; // indent's percent distance
                if (double.IsNaN(param1)) param1 = 0.1;
                else if (param1 < -1) param1 = -1;
                else if (param1 > 1) param1 = 1;
                var indent = Math.Abs(param1) * w;
                if (param1 == 0)
                {
                    var geo = new Geometry(GeometryType.Rectangle)
                    {
                        StartX = 0,
                        StartY = 0,
                        EndX = w,
                        EndY = h
                    };
                    return geo;
                }
                else
                {
                    var geo = new Geometry();
                    if (param1 > 0)
                    {
                        geo.Add(new PathFigure(indent, 0)
                          .Add(new PathSegment(SegmentType.Line, w, 0))
                          .Add(new PathSegment(SegmentType.Line, w - indent, h))
                          .Add(new PathSegment(SegmentType.Line, 0, h).Close()));
                    }
                    else
                    {  // param1 < 0
                        geo.Add(new PathFigure(0, 0)
                          .Add(new PathSegment(SegmentType.Line, w - indent, 0))
                          .Add(new PathSegment(SegmentType.Line, w, h))
                          .Add(new PathSegment(SegmentType.Line, indent, h).Close()));
                    }
                    if (indent < w / 2)
                    {
                        geo.SetSpots(indent / w, 0, (w - indent) / w, 1);
                    }
                    return geo;
                }
            });

            FigureParameter.SetFigureParameter("Trapezoid", 0, new FigureParameter("Indent", .2, -.99, .99));
            Shape.DefineFigureGenerator("Trapezoid", (shape, w, h) => {
                var param1 = (shape != null) ? shape.Parameter1 : double.NaN; // indent's percent distance
                if (double.IsNaN(param1)) param1 = 0.2;
                else if (param1 < 0.5) param1 = -0.5;
                else if (param1 > 0.5) param1 = 0.5;
                var indent = Math.Abs(param1) * w;
                if (param1 == 0)
                {
                    var geo = new Geometry(GeometryType.Rectangle)
                    {
                        StartX = 0,
                        StartY = 0,
                        EndX = w,
                        EndY = h
                    };
                    return geo;
                }
                else
                {
                    var geo = new Geometry();
                    if (param1 > 0)
                    {
                        geo.Add(new PathFigure(indent, 0)
                          .Add(new PathSegment(SegmentType.Line, w - indent, 0))
                          .Add(new PathSegment(SegmentType.Line, w, h))
                          .Add(new PathSegment(SegmentType.Line, 0, h).Close()));
                    }
                    else
                    {  // param1 < 0
                        geo.Add(new PathFigure(0, 0)
                          .Add(new PathSegment(SegmentType.Line, w, 0))
                          .Add(new PathSegment(SegmentType.Line, w - indent, h))
                          .Add(new PathSegment(SegmentType.Line, indent, h).Close()));
                    }
                    if (indent < w / 2)
                    {
                        geo.SetSpots(indent / w, 0, (w - indent) / w, 1);
                    }
                    return geo;
                }
            });

            // The following functions are used by a group of regular figures that are defined below:
            // This allocates a temporary Array that should be freed by the caller.
            Point[] createPolygon(int sides)
            {
                var points = new Point[sides + 1];
                var radius = .5;
                var center = .5;
                var offsetAngle = Math.PI * 1.5;
                var angle = 0d;

                // Loop through each side of the polygon
                for (var i = 0; i < sides; i++)
                {
                    angle = 2 * Math.PI / sides * i + offsetAngle;
                    points[i] = new Point((center + radius * Math.Cos(angle)), (center + radius * Math.Sin(angle)));
                }

                // Add the last line
                points[points.Length - 1] = points[0];
                return points;
            }
            // This allocates a temporary Array that should be freed by the caller.
            Point[] createBurst(int points)
            {
                var star = createStar(points);
                var pts = new Point[points * 3 + 1];

                pts[0] = star[0];
                for (int i = 1, count = 1; i < star.Length; i += 2, count += 3)
                {
                    pts[count] = star[i];
                    pts[count + 1] = star[i];
                    pts[count + 2] = star[i + 1];
                }

                return pts;
            }
            // This allocates a temporary Array that should be freed by the caller.
            Point[] createStar(int points)
            {
                // First, create a regular polygon
                var polygon = createPolygon(points);
                // Calculate the points inbetween
                var pts = new Point[points * 2 + 1];

                var half = (int)Math.Floor(polygon.Length / 2d);
                var count = polygon.Length - 1;
                var offset = (points % 2 == 0) ? 2 : 1;

                for (var i = 0; i < count; i++)
                {
                    // Get the intersection of two lines
                    var p0 = polygon[i];
                    var p1 = polygon[i + 1];
                    var q21 = polygon[(half + i - 1) % count];
                    var q2off = polygon[(half + i + offset) % count];
                    pts[i * 2] = p0;
                    var tempPoint = new Point();
                    pts[i * 2 + 1] = GetIntersection(p0.X, p0.Y,
                      q21.X, q21.Y,
                      p1.X, p1.Y,
                      q2off.X, q2off.Y, out tempPoint);  // ?? not currently managed
                }

                pts[pts.Length - 1] = pts[0];
                return pts;
            }

            Shape.DefineFigureGenerator("Pentagon", (shape, w, h) => {
                var points = createPolygon(5);
                var geo = new Geometry();
                var fig = new PathFigure(points[0].X * w, points[0].Y * h, true);
                geo.Add(fig);
                for (var i = 1; i < 5; i++)
                {
                    fig.Add(new PathSegment(SegmentType.Line, points[i].X * w, points[i].Y * h));
                }
                fig.Add(new PathSegment(SegmentType.Line, points[0].X * w, points[0].Y * h).Close());
                geo.Spot1 = new Spot(.2, .22);
                geo.Spot2 = new Spot(.8, .9);
                return geo;
            });

            Shape.DefineFigureGenerator("Hexagon", (shape, w, h) => {
                var points = createPolygon(6);
                var geo = new Geometry();
                var fig = new PathFigure(points[0].X * w, points[0].Y * h, true);
                geo.Add(fig);
                for (var i = 1; i < 6; i++)
                {
                    fig.Add(new PathSegment(SegmentType.Line, points[i].X * w, points[i].Y * h));
                }
                fig.Add(new PathSegment(SegmentType.Line, points[0].X * w, points[0].Y * h).Close());
                geo.Spot1 = new Spot(.07, .25);
                geo.Spot2 = new Spot(.93, .75);
                return geo;
            });

            Shape.DefineFigureGenerator("Heptagon", (shape, w, h) => {
                var points = createPolygon(7);
                var geo = new Geometry();
                var fig = new PathFigure(points[0].X * w, points[0].Y * h, true);
                geo.Add(fig);
                for (var i = 1; i < 7; i++)
                {
                    fig.Add(new PathSegment(SegmentType.Line, points[i].X * w, points[i].Y * h));
                }
                fig.Add(new PathSegment(SegmentType.Line, points[0].X * w, points[0].Y * h).Close());
                geo.Spot1 = new Spot(.2, .15);
                geo.Spot2 = new Spot(.8, .85);
                return geo;
            });

            Shape.DefineFigureGenerator("Octagon", (shape, w, h) => {
                var points = createPolygon(8);
                var geo = new Geometry();
                var fig = new PathFigure(points[0].X * w, points[0].Y * h, true);
                geo.Add(fig);
                for (var i = 1; i < 8; i++)
                {
                    fig.Add(new PathSegment(SegmentType.Line, points[i].X * w, points[i].Y * h));
                }
                fig.Add(new PathSegment(SegmentType.Line, points[0].X * w, points[0].Y * h).Close());
                geo.Spot1 = new Spot(.15, .15);
                geo.Spot2 = new Spot(.85, .85);
                return geo;
            });

            Shape.DefineFigureGenerator("Cloud", (shape, w, h) => {
                return new Geometry()
                  .Add(new PathFigure(.08034461 * w, .1944299 * h, true)
                    .Add(new PathSegment(SegmentType.Bezier,
                      .2008615 * w, .05349299 * h, -.09239631 * w, .07836421 * h, .1406031 * w, -.0542823 * h))
                    .Add(new PathSegment(SegmentType.Bezier,
                      .4338609 * w, .074219 * h, .2450511 * w, -.00697547 * h, .3776197 * w, -.01112067 * h))
                    .Add(new PathSegment(SegmentType.Bezier,
                      .6558228 * w, .07004196 * h, .4539471 * w, 0, .6066018 * w, -.02526587 * h))
                    .Add(new PathSegment(SegmentType.Bezier,
                      .8921095 * w, .08370865 * h, .6914277 * w, -.01904177 * h, .8921095 * w, -.01220843 * h))
                    .Add(new PathSegment(SegmentType.Bezier,
                      .9147671 * w, .3194596 * h, 1.036446 * w, .04105738 * h, 1.020377 * w, .3022052 * h))
                    .Add(new PathSegment(SegmentType.Bezier,
                      .9082935 * w, .562044 * h, 1.04448 * w, .360238 * h, .992256 * w, .5219009 * h))
                    .Add(new PathSegment(SegmentType.Bezier,
                      .9212406 * w, .8217117 * h, 1.032337 * w, .5771781 * h, 1.018411 * w, .8120651 * h))
                    .Add(new PathSegment(SegmentType.Bezier,
                      .7592566 * w, .9156953 * h, 1.028411 * w, .9571472 * h, .8556702 * w, 1.052487 * h))
                    .Add(new PathSegment(SegmentType.Bezier,
                      .5101666 * w, .9310455 * h, .7431877 * w, 1.009325 * h, .5624123 * w, 1.021761 * h))
                    .Add(new PathSegment(SegmentType.Bezier,
                      .2609328 * w, .9344623 * h, .4820677 * w, 1.031761 * h, .3030112 * w, 1.002796 * h))
                    .Add(new PathSegment(SegmentType.Bezier,
                      .08034461 * w, .870098 * h, .2329994 * w, 1.01518 * h, .03213784 * w, 1.01518 * h))
                    .Add(new PathSegment(SegmentType.Bezier,
                      .06829292 * w, .6545475 * h, -.02812061 * w, .9032597 * h, -.01205169 * w, .6835638 * h))
                    .Add(new PathSegment(SegmentType.Bezier,
                      .06427569 * w, .4265613 * h, -.01812061 * w, .6089503 * h, -.00606892 * w, .4555777 * h))
                    .Add(new PathSegment(SegmentType.Bezier,
                      .08034461 * w, .1944299 * h, -.01606892 * w, .3892545 * h, -.01205169 * w, .1944299 * h)))
                  .SetSpots(.1, .1, .9, .9);
            });

            Shape.DefineFigureGenerator("Procedure", (shape, w, h) => {
                var geo = new Geometry();
                var param1 = (shape != null) ? shape.Parameter1 : double.NaN;
                // Distance of left  and right lines from edge
                if (double.IsNaN(param1)) param1 = .1;
                var fig = new PathFigure(0, 0, true);
                geo.Add(fig);
                fig.Add(new PathSegment(SegmentType.Line, w, 0));
                fig.Add(new PathSegment(SegmentType.Line, w, h));
                fig.Add(new PathSegment(SegmentType.Line, 0, h).Close());
                var fig2 = new PathFigure((1 - param1) * w, 0, false);
                geo.Add(fig2);
                fig2.Add(new PathSegment(SegmentType.Line, (1 - param1) * w, h));
                fig2.Add(new PathSegment(SegmentType.Move, param1 * w, 0));
                fig2.Add(new PathSegment(SegmentType.Line, param1 * w, h));
                // ??? geo.Spot1 = new Spot(param1, 0);
                // ??? geo.Spot2 = new Spot(1 - param1, 1);
                return geo;
            });

            Shape.DefineFigureGenerator("BpmnActivityLoop", (shape, w, h) => {
                var geo = new Geometry();
                var r = .5;
                var cx = 0;  // offset from Center x
                var cy = 0;  // offset from Center y
                var d = r * KAPPA;
                var mx1 = (.4 * Math.Sqrt(2) / 2 + .5);
                var my1 = (.5 - .5 * Math.Sqrt(2) / 2);
                var x1 = 1;
                var y1 = .5;
                var x2 = .5;
                var y2 = 0;
                var fig = new PathFigure(mx1 * w, (1 - my1) * h, false);
                geo.Add(fig);
                fig.Add(new PathSegment(SegmentType.Bezier, x1 * w, y1 * h, x1 * w, .7 * h,
                  x1 * w, y1 * h));
                fig.Add(new PathSegment(SegmentType.Bezier, (x2 + cx) * w, (y2 + cx) * h, (.5 + r + cx) * w, (.5 - d + cx) * h,
                  (.5 + d + cx) * w, (.5 - r + cx) * h));
                fig.Add(new PathSegment(SegmentType.Bezier, (.5 - r + cx) * w, (.5 + cy) * h, (.5 - d + cx) * w, (.5 - r + cy) * h,
                  (.5 - r + cx) * w, (.5 - d + cy) * h));
                fig.Add(new PathSegment(SegmentType.Bezier, (.35 + cx) * w, .9 * h, (.5 - r + cx) * w, (.5 + d + cy) * h,
                  (.5 - d + cx) * w, .9 * h));
                // Arrowhead
                fig.Add(new PathSegment(SegmentType.Move, (.25 + cx) * w, 0.8 * h));
                fig.Add(new PathSegment(SegmentType.Line, (.35 + cx) * w, 0.9 * h));
                fig.Add(new PathSegment(SegmentType.Line, (.20 + cx) * w, 0.95 * h));
                return geo;
            });
            
            FigureParameter.SetFigureParameter("Arrow", 0, new FigureParameter("ArrowheadWidth", .3, .01, .99));
            FigureParameter.SetFigureParameter("Arrow", 1, new FigureParameter("TailHeight", .3, .01, .99));
            Shape.DefineFigureGenerator("Arrow", (shape, w, h) => {
                var param1 = (shape != null) ? shape.Parameter1 : double.NaN;  // % width of arrowhead
                if (double.IsNaN(param1)) param1 = .3;
                var param2 = (shape != null) ? shape.Parameter2 : double.NaN;  // % height of tail
                if (double.IsNaN(param2)) param2 = .3;
                var x = (1 - param1) * w;
                var y1 = (.5 - param2 / 2) * h;
                var y2 = (.5 + param2 / 2) * h;
                var geo = new Geometry();
                var fig = new PathFigure(0, y1, true);
                geo.Add(fig);
                fig.Add(new PathSegment(SegmentType.Line, x, y1));
                fig.Add(new PathSegment(SegmentType.Line, x, 0));
                fig.Add(new PathSegment(SegmentType.Line, x, 0));
                fig.Add(new PathSegment(SegmentType.Line, w, .5 * h));
                fig.Add(new PathSegment(SegmentType.Line, x, h));
                fig.Add(new PathSegment(SegmentType.Line, x, y2));
                fig.Add(new PathSegment(SegmentType.Line, 0, y2).Close());
                geo.Spot1 = new Spot(0, y1 / h);
                var tempPoint = new Point();
                var temp = GetIntersection(0, y2 / h,
                    1, y2 / h,
                    x / w, 1,
                    1, .5,
                    out tempPoint);
                geo.Spot2 = new Spot(temp.X, temp.Y);
                return geo;
            });

        }
    }
}
