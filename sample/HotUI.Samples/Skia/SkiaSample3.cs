﻿using System;
using System.Collections.Generic;
using System.Text;
using HotUI.Skia;

namespace HotUI.Samples.Skia
{
    public class SkiaSample3 : View
    {
        readonly State<float> _strokeSize = 2;
        readonly State<string> _strokeColor = "#000000";

        [Body]
        View body() => new VStack()
        {
            new VStack()
            {
                new HStack()
                {
                    new Text("Stroke Width:"),
                    new Slider(_strokeSize, 1, 10, 1)
                },
                new HStack()
                {
                    new Text("Stroke Color!:"),
                    new TextField(_strokeColor),
                },
                //new ScrollView{
                    new HStack
                    {
                        new Button("Black", () =>
                        {
                            _strokeColor.Value = Color.Black.ToHexString();
                        }).TextColor(Color.Black),
                        new Button("Blue", () =>
                        {
                            _strokeColor.Value = Color.Blue.ToHexString();
                        }).TextColor(Color.Blue),
                        new Button("Red", () =>
                        {
                            _strokeColor.Value = Color.Red.ToHexString();
                        }).TextColor(Color.Red),
                    },
                //},
                new BindableFingerPaint(
                    strokeSize:_strokeSize,
                    strokeColor:_strokeColor).ToView().Frame(height:400)
            },
        };
    }
}