using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "ARMarker" defined in "ARMarker.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from ARMarker.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit ARMarker.idl instead.
*
*/
public class ARMarkerPubSubType : Halodi.CDR.TopicDataType<ARMarker>
{
   public override string Name => "halodi_msgs::msg::dds_::ARMarker_";


   
   public override void serialize(halodi_msgs.msg.ARMarker data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, halodi_msgs.msg.ARMarker data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.ARMarker data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.ARMarker data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.data.Length + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.points.Count; ++i0)
      {
          current_alignment += geometry_msgs.msg.PointPubSubType.getCdrSerializedSize(data.points[i0], current_alignment);}

      current_alignment += geometry_msgs.msg.PoseStampedPubSubType.getCdrSerializedSize(data.pose, current_alignment);


      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.ARMarker data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_d(data.data);

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
      geometry_msgs.msg.PoseStampedPubSubType.write(data.pose, cdr);

   }

   public static void read(halodi_msgs.msg.ARMarker data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.data = cdr.read_type_d();	

      int points_length = cdr.read_type_2();
      data.points = new System.Collections.Generic.List<geometry_msgs.msg.Point>(points_length);
      for(int i = 0; i < points_length; i++)
      {
      	geometry_msgs.msg.Point new_points = geometry_msgs.msg.PointPubSubType.Create(); 
      	geometry_msgs.msg.PointPubSubType.read(new_points, cdr);
      	data.points.Add(new_points);	
      	
      }

      	
      data.pose = geometry_msgs.msg.PoseStampedPubSubType.Create();
      geometry_msgs.msg.PoseStampedPubSubType.read(data.pose, cdr);
      	

   }


    public static void Copy(halodi_msgs.msg.ARMarker src, halodi_msgs.msg.ARMarker target)
    {
        target.Set(src);
    }


}


}