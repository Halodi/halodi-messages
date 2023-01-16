using System.IO;
namespace visualization_msgs.msg
{

/**
* 
* Topic data type of the struct "Marker" defined in "Marker.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Marker.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Marker.idl instead.
*
*/
public class MarkerPubSubType : Halodi.CDR.TopicDataType<Marker>
{
   public override string Name => "visualization_msgs::msg::dds_::Marker_";


   public static int getCdrSerializedSize(visualization_msgs.msg.Marker data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(visualization_msgs.msg.Marker data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.ns.Length + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += geometry_msgs.msg.PosePubSubType.getCdrSerializedSize(data.pose, current_alignment);

      current_alignment += geometry_msgs.msg.Vector3PubSubType.getCdrSerializedSize(data.scale, current_alignment);

      current_alignment += std_msgs.msg.ColorRGBAPubSubType.getCdrSerializedSize(data.color, current_alignment);

      current_alignment += builtin_interfaces.msg.DurationPubSubType.getCdrSerializedSize(data.lifetime, current_alignment);

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.points.Count; ++i0)
      {
          current_alignment += geometry_msgs.msg.PointPubSubType.getCdrSerializedSize(data.points[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.colors.Count; ++i0)
      {
          current_alignment += std_msgs.msg.ColorRGBAPubSubType.getCdrSerializedSize(data.colors[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.text.Length + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.mesh_resource.Length + 1;

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);



      return current_alignment - initial_alignment;
   }

   public static void write(visualization_msgs.msg.Marker data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      cdr.write_type_d(data.ns);

      cdr.write_type_2(data.id);

      cdr.write_type_2(data.type);

      cdr.write_type_2(data.action);

      geometry_msgs.msg.PosePubSubType.write(data.pose, cdr);

      geometry_msgs.msg.Vector3PubSubType.write(data.scale, cdr);

      std_msgs.msg.ColorRGBAPubSubType.write(data.color, cdr);

      builtin_interfaces.msg.DurationPubSubType.write(data.lifetime, cdr);

      cdr.write_type_7(data.frame_locked);

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
      	if(data.colors == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int colors_length = data.colors.Count;
            cdr.write_type_2(colors_length);
            for (int i0 = 0; i0 < colors_length; i0++)
            {
      			std_msgs.msg.ColorRGBAPubSubType.write(data.colors[i0], cdr);	      }
        }
      cdr.write_type_d(data.text);

      cdr.write_type_d(data.mesh_resource);

      cdr.write_type_7(data.mesh_use_embedded_materials);

   }

   public static void read(visualization_msgs.msg.Marker data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	
      data.ns = cdr.read_type_d();	
      data.id=cdr.read_type_2();
      	
      data.type=cdr.read_type_2();
      	
      data.action=cdr.read_type_2();
      	
      data.pose = geometry_msgs.msg.PosePubSubType.Create();
      geometry_msgs.msg.PosePubSubType.read(data.pose, cdr);
      	
      data.scale = geometry_msgs.msg.Vector3PubSubType.Create();
      geometry_msgs.msg.Vector3PubSubType.read(data.scale, cdr);
      	
      data.color = std_msgs.msg.ColorRGBAPubSubType.Create();
      std_msgs.msg.ColorRGBAPubSubType.read(data.color, cdr);
      	
      data.lifetime = builtin_interfaces.msg.DurationPubSubType.Create();
      builtin_interfaces.msg.DurationPubSubType.read(data.lifetime, cdr);
      	
      data.frame_locked=cdr.read_type_7();
      	

      int points_length = cdr.read_type_2();
      data.points = new System.Collections.Generic.List<geometry_msgs.msg.Point>(points_length);
      for(int i = 0; i < points_length; i++)
      {
      	geometry_msgs.msg.Point new_points = geometry_msgs.msg.PointPubSubType.Create(); 
      	geometry_msgs.msg.PointPubSubType.read(new_points, cdr);
      	data.points.Add(new_points);	
      	
      }

      	

      int colors_length = cdr.read_type_2();
      data.colors = new System.Collections.Generic.List<std_msgs.msg.ColorRGBA>(colors_length);
      for(int i = 0; i < colors_length; i++)
      {
      	std_msgs.msg.ColorRGBA new_colors = std_msgs.msg.ColorRGBAPubSubType.Create(); 
      	std_msgs.msg.ColorRGBAPubSubType.read(new_colors, cdr);
      	data.colors.Add(new_colors);	
      	
      }

      	
      data.text = cdr.read_type_d();	
      data.mesh_resource = cdr.read_type_d();	
      data.mesh_use_embedded_materials=cdr.read_type_7();
      	

   }


	public override void Serialize(visualization_msgs.msg.Marker data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(visualization_msgs.msg.Marker data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(visualization_msgs.msg.Marker data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(visualization_msgs.msg.Marker src, visualization_msgs.msg.Marker target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(visualization_msgs.msg.Marker src, visualization_msgs.msg.Marker target)
    {
    	Copy(src, target);
    }


}


}