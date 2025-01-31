﻿namespace DotNetMauiDrawingViewPaintAppSample.Figures;

public interface IFigure
{
	void Draw(ICanvas canvas, RectF rectF);
	Task Configure();
}