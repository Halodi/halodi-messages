// generated from rosidl_typesupport_introspection_cpp/resource/idl__type_support.cpp.em
// with input from halodi_msgs:msg/DrivingTrajectory.idl
// generated code does not contain a copyright notice

#include "array"
#include "cstddef"
#include "string"
#include "vector"
#include "rosidl_generator_c/message_type_support_struct.h"
#include "rosidl_typesupport_cpp/message_type_support.hpp"
#include "rosidl_typesupport_interface/macros.h"
#include "halodi_msgs/msg/driving_trajectory__struct.hpp"
#include "rosidl_typesupport_introspection_cpp/field_types.hpp"
#include "rosidl_typesupport_introspection_cpp/identifier.hpp"
#include "rosidl_typesupport_introspection_cpp/message_introspection.hpp"
#include "rosidl_typesupport_introspection_cpp/message_type_support_decl.hpp"
#include "rosidl_typesupport_introspection_cpp/visibility_control.h"

namespace halodi_msgs
{

namespace msg
{

namespace rosidl_typesupport_introspection_cpp
{

void DrivingTrajectory_init_function(
  void * message_memory, rosidl_generator_cpp::MessageInitialization _init)
{
  new (message_memory) halodi_msgs::msg::DrivingTrajectory(_init);
}

void DrivingTrajectory_fini_function(void * message_memory)
{
  auto typed_message = static_cast<halodi_msgs::msg::DrivingTrajectory *>(message_memory);
  typed_message->~DrivingTrajectory();
}

size_t size_function__DrivingTrajectory__trajectory_points(const void * untyped_member)
{
  const auto * member = reinterpret_cast<const std::vector<halodi_msgs::msg::DrivingTrajectoryPoint> *>(untyped_member);
  return member->size();
}

const void * get_const_function__DrivingTrajectory__trajectory_points(const void * untyped_member, size_t index)
{
  const auto & member =
    *reinterpret_cast<const std::vector<halodi_msgs::msg::DrivingTrajectoryPoint> *>(untyped_member);
  return &member[index];
}

void * get_function__DrivingTrajectory__trajectory_points(void * untyped_member, size_t index)
{
  auto & member =
    *reinterpret_cast<std::vector<halodi_msgs::msg::DrivingTrajectoryPoint> *>(untyped_member);
  return &member[index];
}

void resize_function__DrivingTrajectory__trajectory_points(void * untyped_member, size_t size)
{
  auto * member =
    reinterpret_cast<std::vector<halodi_msgs::msg::DrivingTrajectoryPoint> *>(untyped_member);
  member->resize(size);
}

static const ::rosidl_typesupport_introspection_cpp::MessageMember DrivingTrajectory_message_member_array[3] = {
  {
    "look_ahead_distance",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::DrivingTrajectory, look_ahead_distance),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "K",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_DOUBLE,  // type
    0,  // upper bound of string
    nullptr,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::DrivingTrajectory, K),  // bytes offset in struct
    nullptr,  // default value
    nullptr,  // size() function pointer
    nullptr,  // get_const(index) function pointer
    nullptr,  // get(index) function pointer
    nullptr  // resize(index) function pointer
  },
  {
    "trajectory_points",  // name
    ::rosidl_typesupport_introspection_cpp::ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    ::rosidl_typesupport_introspection_cpp::get_message_type_support_handle<halodi_msgs::msg::DrivingTrajectoryPoint>(),  // members of sub message
    true,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs::msg::DrivingTrajectory, trajectory_points),  // bytes offset in struct
    nullptr,  // default value
    size_function__DrivingTrajectory__trajectory_points,  // size() function pointer
    get_const_function__DrivingTrajectory__trajectory_points,  // get_const(index) function pointer
    get_function__DrivingTrajectory__trajectory_points,  // get(index) function pointer
    resize_function__DrivingTrajectory__trajectory_points  // resize(index) function pointer
  }
};

static const ::rosidl_typesupport_introspection_cpp::MessageMembers DrivingTrajectory_message_members = {
  "halodi_msgs::msg",  // message namespace
  "DrivingTrajectory",  // message name
  3,  // number of fields
  sizeof(halodi_msgs::msg::DrivingTrajectory),
  DrivingTrajectory_message_member_array,  // message members
  DrivingTrajectory_init_function,  // function to initialize message memory (memory has to be allocated)
  DrivingTrajectory_fini_function  // function to terminate message instance (will not free memory)
};

static const rosidl_message_type_support_t DrivingTrajectory_message_type_support_handle = {
  ::rosidl_typesupport_introspection_cpp::typesupport_identifier,
  &DrivingTrajectory_message_members,
  get_message_typesupport_handle_function,
};

}  // namespace rosidl_typesupport_introspection_cpp

}  // namespace msg

}  // namespace halodi_msgs


namespace rosidl_typesupport_introspection_cpp
{

template<>
ROSIDL_TYPESUPPORT_INTROSPECTION_CPP_PUBLIC
const rosidl_message_type_support_t *
get_message_type_support_handle<halodi_msgs::msg::DrivingTrajectory>()
{
  return &::halodi_msgs::msg::rosidl_typesupport_introspection_cpp::DrivingTrajectory_message_type_support_handle;
}

}  // namespace rosidl_typesupport_introspection_cpp

#ifdef __cplusplus
extern "C"
{
#endif

ROSIDL_TYPESUPPORT_INTROSPECTION_CPP_PUBLIC
const rosidl_message_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_cpp, halodi_msgs, msg, DrivingTrajectory)() {
  return &::halodi_msgs::msg::rosidl_typesupport_introspection_cpp::DrivingTrajectory_message_type_support_handle;
}

#ifdef __cplusplus
}
#endif
