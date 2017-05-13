﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xaml.Schema;
using Microsoft.Maps.MapControl.WPF;
using Newtonsoft.Json;

namespace Emergy.Service.WPF.Models
{
    public class Signal : INotifyPropertyChanged
    {
        private string _id;
        private double _latitude;
        private double _longitude;
	    //private Point p;
	    private Location _location;

        private ServiceOwn _own;

        [JsonProperty("Id")]
        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

	    public Location Location
	    {
			get { return _location; }
		    set
		    {
			    _location = value;
				OnPropertyChanged(nameof(Location));
			}		    
		}

        public double Latitude
        {
            get { return _latitude; }
            set
            {
                _latitude = value;
                OnPropertyChanged(nameof(Latitude));
            }
        }

        public double Longitude
        {
            get { return _longitude; }
            set
            {
                _longitude = value;
                OnPropertyChanged(nameof(Longitude));
            }
        }

        public ServiceOwn Own
        {
            get { return _own; }
            set
            {
                _own = value;
                OnPropertyChanged(nameof(Own));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

	    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	    {
		    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	    }
    }
}
