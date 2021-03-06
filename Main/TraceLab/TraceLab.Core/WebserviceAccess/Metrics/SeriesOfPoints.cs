﻿// TraceLab - Software Traceability Instrument to Facilitate and Empower Traceability Research
// Copyright (C) 2012-2013 CoEST - National Science Foundation MRI-R2 Grant # CNS: 0959924
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see<http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace TraceLab.Core.WebserviceAccess.Metrics
{
    [DataContract]
    public abstract class SeriesOfPoints<T> : IMetricResult
    {
        public SeriesOfPoints(string metricName) 
        {
            m_metricName = metricName;
            m_points = new List<T>();
        }

        public SeriesOfPoints(string metricName, List<T> points)
        {
            m_metricName = metricName;
            m_points = points;
        }

        //public SeriesOfPoints(TraceLabSDK.Types.Contests.BoxSummaryData boxSummaryData)
        //{
        //    MetricName = boxSummaryData.MetricName;
        //    m_points = new List<BoxPlotPointDTO>();
        //    foreach (TraceLabSDK.Types.Contests.BoxPlotPoint point in boxSummaryData.Points)
        //    {
        //        m_points.Add(new BoxPlotPointDTO(point));
        //    }
        //}

        protected string m_metricName;
        [DataMember]
        public string MetricName
        {
            get
            {
                return m_metricName;
            }
            set
            {
                m_metricName = value;
            }
        }

        protected List<T> m_points;
        [DataMember]
        public List<T> Points
        {
            get { return m_points; }
            set { m_points = value; }
        }
    }
}
