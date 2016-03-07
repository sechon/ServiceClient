using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    ShowTrackerServiceReference.ShowTrackerServicesClient db 
        = new ShowTrackerServiceReference.ShowTrackerServicesClient();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadDropDownArtist();
            LoadDropDownVenue();
        }
    }

    protected void DropDownListArtist_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillGridArtist();
    }

    protected void DropDownListVenue_SelectedIndexChanged(object sender, EventArgs e)
    {
        FillGridVenue();
    }

    protected void LoadDropDownArtist()
    {
        string[] artists = db.GetArtists();
        DropDownListArtist.DataSource = artists;
        DropDownListArtist.DataBind();
        DropDownListArtist.Items.Insert(0, "Pick an Artist");
    }

    protected void LoadDropDownVenue()
    {
        string[] venues = db.GetVenues();
        DropDownListVenue.DataSource = venues;
        DropDownListVenue.DataBind();
        DropDownListVenue.Items.Insert(0, "Pick a Venue");
    }

    protected void FillGridArtist()
    {
        string artist = DropDownListArtist.SelectedItem.Text;
        ShowTrackerServiceReference.ShowLite[] shows = db.GetShowByArtist(artist);
        GridView.DataSource = shows;
        GridView.DataBind();
    }

    protected void FillGridVenue()
    {
        string venue = DropDownListVenue.SelectedItem.Text;
        ShowTrackerServiceReference.ShowLite[] shows = db.GetShowByVenue(venue);
        GridView.DataSource = shows;
        GridView.DataBind();
    }
}