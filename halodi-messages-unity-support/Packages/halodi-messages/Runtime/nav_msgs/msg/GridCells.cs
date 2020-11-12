using System.Text;
namespace nav_msgs.msg
{


/**
       * An array of cells in a 2D grid
       */
[System.Serializable]
public class GridCells
{
   public std_msgs.msg.Header header;
   public float cell_width;
   public float cell_height;
   public System.Collections.Generic.List<geometry_msgs.msg.Point> cells;


   public void Set(GridCells other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      cell_width = other.cell_width;

      cell_height = other.cell_height;


      if(other.cells == null)
      {
      	cells = null;
      }
      else
      {
      	cells = new System.Collections.Generic.List<geometry_msgs.msg.Point>(other.cells.Count);
      	for(int i1 = 0; i1 < other.cells.Count; i1++)
      	{
      		if(other.cells[i1] == null)
      		{
      			cells.Add(null);
      		}
      		else
      		{
      			geometry_msgs.msg.Point newElement = geometry_msgs.msg.PointPubSubType.Create();
      	   		geometry_msgs.msg.PointPubSubType.Copy(other.cells[i1], newElement);
      	   		cells.Add(newElement);
      		}	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("GridCells {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("cell_width=");
      builder.Append(this.cell_width);      builder.Append(", ");
      builder.Append("cell_height=");
      builder.Append(this.cell_height);      builder.Append(", ");
      builder.Append("cells=");
      builder.Append(this.cells);
      builder.Append("}");
      return builder.ToString();
   }
}


}