using System.IO;
namespace geometry_msgs.msg
{

/**
* 
* Topic data type of the struct "PolygonStamped" defined in "PolygonStamped.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from PolygonStamped.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit PolygonStamped.idl instead.
*
*/
public class PolygonStampedPubSubType : Halodi.CDR.TopicDataType<geometry_msgs.msg.PolygonStamped>
{
   public override string Name => "geometry_msgs::msg::dds_::PolygonStamped_";


   
   public override void serialize(geometry_msgs.msg.PolygonStamped data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, geometry_msgs.msg.PolygonStamped data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(geometry_msgs.msg.PolygonStamped data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(geometry_msgs.msg.PolygonStamped data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += geometry_msgs.msg.PolygonPubSubType.getCdrSerializedSize(data.polygon, current_alignment);


      return current_alignment - initial_alignment;
   }

   public static void write(geometry_msgs.msg.PolygonStamped data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      geometry_msgs.msg.PolygonPubSubType.write(data.polygon, cdr);

   }

   public static void read(geometry_msgs.msg.PolygonStamped data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	
      data.polygon = geometry_msgs.msg.PolygonPubSubType.Create();
      geometry_msgs.msg.PolygonPubSubType.read(data.polygon, cdr);
      	

   }


    public static void Copy(geometry_msgs.msg.PolygonStamped src, geometry_msgs.msg.PolygonStamped target)
    {
        target.Set(src);
    }


}


}