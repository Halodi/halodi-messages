// generated from rosidl_generator_cpp/resource/idl__struct.hpp.em
// with input from halodi_msgs:msg/ARMarkers.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__AR_MARKERS__STRUCT_HPP_
#define HALODI_MSGS__MSG__AR_MARKERS__STRUCT_HPP_

#include <rosidl_generator_cpp/bounded_vector.hpp>
#include <rosidl_generator_cpp/message_initialization.hpp>
#include <algorithm>
#include <array>
#include <memory>
#include <string>
#include <vector>


// Include directives for member types
// Member 'header'
#include "std_msgs/msg/header__struct.hpp"
// Member 'markers'
#include "halodi_msgs/msg/ar_marker__struct.hpp"

#ifndef _WIN32
# define DEPRECATED__halodi_msgs__msg__ARMarkers __attribute__((deprecated))
#else
# define DEPRECATED__halodi_msgs__msg__ARMarkers __declspec(deprecated)
#endif

namespace halodi_msgs
{

namespace msg
{

// message struct
template<class ContainerAllocator>
struct ARMarkers_
{
  using Type = ARMarkers_<ContainerAllocator>;

  explicit ARMarkers_(rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  : header(_init)
  {
    (void)_init;
  }

  explicit ARMarkers_(const ContainerAllocator & _alloc, rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  : header(_alloc, _init)
  {
    (void)_init;
  }

  // field types and members
  using _header_type =
    std_msgs::msg::Header_<ContainerAllocator>;
  _header_type header;
  using _markers_type =
    rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::ARMarker_<ContainerAllocator>, 255, typename ContainerAllocator::template rebind<halodi_msgs::msg::ARMarker_<ContainerAllocator>>::other>;
  _markers_type markers;

  // setters for named parameter idiom
  Type & set__header(
    const std_msgs::msg::Header_<ContainerAllocator> & _arg)
  {
    this->header = _arg;
    return *this;
  }
  Type & set__markers(
    const rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::ARMarker_<ContainerAllocator>, 255, typename ContainerAllocator::template rebind<halodi_msgs::msg::ARMarker_<ContainerAllocator>>::other> & _arg)
  {
    this->markers = _arg;
    return *this;
  }

  // constant declarations

  // pointer types
  using RawPtr =
    halodi_msgs::msg::ARMarkers_<ContainerAllocator> *;
  using ConstRawPtr =
    const halodi_msgs::msg::ARMarkers_<ContainerAllocator> *;
  using SharedPtr =
    std::shared_ptr<halodi_msgs::msg::ARMarkers_<ContainerAllocator>>;
  using ConstSharedPtr =
    std::shared_ptr<halodi_msgs::msg::ARMarkers_<ContainerAllocator> const>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::ARMarkers_<ContainerAllocator>>>
  using UniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::ARMarkers_<ContainerAllocator>, Deleter>;

  using UniquePtr = UniquePtrWithDeleter<>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::ARMarkers_<ContainerAllocator>>>
  using ConstUniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::ARMarkers_<ContainerAllocator> const, Deleter>;
  using ConstUniquePtr = ConstUniquePtrWithDeleter<>;

  using WeakPtr =
    std::weak_ptr<halodi_msgs::msg::ARMarkers_<ContainerAllocator>>;
  using ConstWeakPtr =
    std::weak_ptr<halodi_msgs::msg::ARMarkers_<ContainerAllocator> const>;

  // pointer types similar to ROS 1, use SharedPtr / ConstSharedPtr instead
  // NOTE: Can't use 'using' here because GNU C++ can't parse attributes properly
  typedef DEPRECATED__halodi_msgs__msg__ARMarkers
    std::shared_ptr<halodi_msgs::msg::ARMarkers_<ContainerAllocator>>
    Ptr;
  typedef DEPRECATED__halodi_msgs__msg__ARMarkers
    std::shared_ptr<halodi_msgs::msg::ARMarkers_<ContainerAllocator> const>
    ConstPtr;

  // comparison operators
  bool operator==(const ARMarkers_ & other) const
  {
    if (this->header != other.header) {
      return false;
    }
    if (this->markers != other.markers) {
      return false;
    }
    return true;
  }
  bool operator!=(const ARMarkers_ & other) const
  {
    return !this->operator==(other);
  }
};  // struct ARMarkers_

// alias to use template instance with default allocator
using ARMarkers =
  halodi_msgs::msg::ARMarkers_<std::allocator<void>>;

// constant definitions

}  // namespace msg

}  // namespace halodi_msgs

#endif  // HALODI_MSGS__MSG__AR_MARKERS__STRUCT_HPP_
