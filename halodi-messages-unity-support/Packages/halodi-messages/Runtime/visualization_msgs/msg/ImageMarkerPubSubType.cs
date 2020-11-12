using System.IO;
namespace visualization_msgs.msg
{

/**
* 
* Topic data type of the struct "ImageMarker" defined in "ImageMarker.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from ImageMarker.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit ImageMarker.idl instead.
*
*/
public class ImageMarkerPubSubType : Halodi.CDR.TopicDataType<visualization_msgs.msg.ImageMarker>
{
   public override string Name => "visualization_msgs::msg::dds_::ImageMarker_";


   
   public override void serialize(visualization_msgs.msg.ImageMarker data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, visualization_msgs.msg.ImageMarker data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(visualization_msgs.msg.ImageMarker data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(visualization_msgs.msg.ImageMarker data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.ns.Length + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += geometry_msgs.msg.PointPubSubType.getCdrSerializedSize(data.position, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += std_msgs.msg.ColorRGBAPubSubType.getCdrSerializedSize(data.outline_color, current_alignment);

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += std_msgs.msg.ColorRGBAPubSubType.getCdrSerializedSize(data.fill_color, current_alignment);

      current_alignment += builtin_interfaces.msg.DurationPubSubType.getCdrSerializedSize(data.lifetime, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.points.Count; ++i0)
      {
          current_alignment += geometry_msgs.msg.PointPubSubType.getCdrSerializedSize(data.points[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.outline_colors.Count; ++i0)
      {
          current_alignment += std_msgs.msg.ColorRGBAPubSubType.getCdrSerializedSize(data.outline_colors[i0], current_alignment);}


      return current_alignment - initial_alignment;
   }

   public static void write(visualization_msgs.msg.ImageMarker data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      cdr.write_type_d(data.ns);

      cdr.write_type_2(data.id);

      cdr.write_type_2(data.type);

      cdr.write_type_2(data.action);

      geometry_msgs.msg.PointPubSubType.write(data.position, cdr);

      cdr.write_type_5(data.scale);

      std_msgs.msg.ColorRGBAPubSubType.write(data.outline_color, cdr);

      cdr.write_type_9(data.filled);

      std_msgs.msg.ColorRGBAPubSubType.write(data.fill_color, cdr);

      builtin_interfaces.msg.DurationPubSubType.write(data.lifetime, cdr);

      	if(data.points == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int points_length = data.points.Count;
            cdr.write_type_2(points_length);
            for (int i0 = 0; i0 < points_length; i0++)
            {
      			geometry_msgs.msg.PointPubSubType.write(data.points[i0], cdr);	      }
        }
      	if(data.outline_colors == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int outline_colors_length = data.outline_colors.Count;
            cdr.write_type_2(outline_colors_length);
            for (int i0 = 0; i0 < outline_colors_length; i0++)
            {
      			std_msgs.msg.ColorRGBAPubSubType.write(data.outline_colors[i0], cdr);	      }
        }
   }

   public static void read(visualization_msgs.msg.ImageMarker data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	
      data.ns = cdr.read_type_d();	
      data.id=cdr.read_type_2();
      	
      data.type=cdr.read_type_2();
      	
      data.action=cdr.read_type_2();
      	
      data.position = geometry_msgs.msg.PointPubSubType.Create();
      geometry_msgs.msg.PointPubSubType.read(data.position, cdr);
      	
      data.scale=cdr.read_type_5();
      	
      data.outline_color = std_msgs.msg.ColorRGBAPubSubType.Create();
      std_msgs.msg.ColorRGBAPubSubType.read(data.outline_color, cdr);
      	
      data.filled=cdr.read_type_9();
      	
      data.fill_color = std_msgs.msg.ColorRGBAPubSubType.Create();
      std_msgs.msg.ColorRGBAPubSubType.read(data.fill_color, cdr);
      	
      data.lifetime = builtin_interfaces.msg.DurationPubSubType.Create();
      builtin_interfaces.msg.DurationPubSubType.read(data.lifetime, cdr);
      	

      int points_length = cdr.read_type_2();
      data.points = new System.Collections.Generic.List<geometry_msgs.msg.Point>(points_length);
      for(int i = 0; i < points_length; i++)
      {
      	geometry_msgs.msg.Point new_points = geometry_msgs.msg.PointPubSubType.Create(); 
      	geometry_msgs.msg.PointPubSubType.read(new_points, cdr);
      	data.points.Add(new_points);	
      	
      }

      	

      int outline_colors_length = cdr.read_type_2();
      data.outline_colors = new System.Collections.Generic.List<std_msgs.msg.ColorRGBA>(outline_colors_length);
      for(int i = 0; i < outline_colors_length; i++)
      {
      	std_msgs.msg.ColorRGBA new_outline_colors = std_msgs.msg.ColorRGBAPubSubType.Create(); 
      	std_msgs.msg.ColorRGBAPubSubType.read(new_outline_colors, cdr);
      	data.outline_colors.Add(new_outline_colors);	
      	
      }

      	

   }


    public static void Copy(visualization_msgs.msg.ImageMarker src, visualization_msgs.msg.ImageMarker target)
    {
        target.Set(src);
    }


}


}