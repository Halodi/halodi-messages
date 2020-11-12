using System.Text;
namespace nav_msgs.msg
{


/**
       * This hold basic information about the characterists of the OccupancyGrid
       */
[System.Serializable]
public class MapMetaData
{
   /**
            * The time at which the map was loaded
            */
   public builtin_interfaces.msg.Time map_load_time;
   /**
            * The map resolution [m/cell]
            */
   public float resolution;
   /**
            * Map width [cells]
            */
   public uint width;
   /**
            * Map height [cells]
            */
   public uint height;
   /**
            * The origin of the map [m, m, rad].  This is the real-world pose of the
            * cell (0,0) in the map.
            */
   public geometry_msgs.msg.Pose origin;


   public void Set(MapMetaData other)
   {
      builtin_interfaces.msg.TimePubSubType.Copy(other.map_load_time, map_load_time);

      resolution = other.resolution;

      width = other.width;

      height = other.height;

      geometry_msgs.msg.PosePubSubType.Copy(other.origin, origin);

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("MapMetaData {");
      builder.Append("map_load_time=");
      builder.Append(this.map_load_time);      builder.Append(", ");
      builder.Append("resolution=");
      builder.Append(this.resolution);      builder.Append(", ");
      builder.Append("width=");
      builder.Append(this.width);      builder.Append(", ");
      builder.Append("height=");
      builder.Append(this.height);      builder.Append(", ");
      builder.Append("origin=");
      builder.Append(this.origin);
      builder.Append("}");
      return builder.ToString();
   }
}


}